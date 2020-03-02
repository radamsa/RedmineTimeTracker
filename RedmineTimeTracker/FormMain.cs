using Redmine.Net.Api;
using Redmine.Net.Api.Async;
using Redmine.Net.Api.Types;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedmineTimeTracker
{
    public partial class FormMain : Form
    {
        private RedmineManager m_redmineManager;
        private SQLiteConnection m_dbconnection;

        private int m_activeIssueId;
        private TimeSpan m_activeTotal;
        private Session m_activeSession;
        private Timer m_activeSessionTimer;

        private class ListViewGroupSorter : IComparer
        {
            private SortOrder order;

            // Stores the sort order.
            public ListViewGroupSorter(SortOrder theOrder)
            {
                order = theOrder;
            }

            // Compares the groups by header value, using the saved sort
            // order to return the correct value.
            public int Compare(object x, object y)
            {
                int result = string.Compare(((ListViewGroup)x).Header, ((ListViewGroup)y).Header);
                return (order == SortOrder.Ascending) ? result : -result;
            }
        }

        public FormMain()
        {
            InitializeComponent();

            OpenDatabase(Properties.Settings.Default.DatabasePath);
        }

        public void OpenDatabase(string path)
        {
            CloseDatabase();

            m_dbconnection = new SQLiteConnection($"Data Source={path}; Version = 3; New = True; Compress = True;");
            m_dbconnection.Open();

            using (var cmd = m_dbconnection.CreateCommand())
            {
                cmd.CommandText = @"CREATE TABLE IF NOT EXISTS timetracker (issueId INT, sessionBegin REAL, sessionEnd REAL);";
                cmd.ExecuteNonQuery();
            }
        }

        private void CloseDatabase()
        {
            if (null != m_dbconnection)
            {
                m_dbconnection.Dispose();
                m_dbconnection = null;
            }
        }

        private void uibtnSignIn_Click(object sender, EventArgs e)
        {
            m_redmineManager = new RedmineManager(Properties.Settings.Default.URL, Properties.Settings.Default.Login, Properties.Settings.Default.Password);

            UpdateIssues();
            VisualSetSignedIn(true);
        }

        private void VisualSetSignedIn(bool isSignedIn)
        {
            uibtnSignIn.Visible = !isSignedIn;
            uibtnUpdateIssues.Visible = isSignedIn;
            uibtnStartStop.Visible = isSignedIn;
            uiSessionTimer.Visible = isSignedIn;
            uibtnReport.Visible = isSignedIn;
        }

        private async void UpdateIssues()
        {
            if (null == m_redmineManager)
            {
                MessageBox.Show("Please sign in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            uiTaskList.Groups.Clear();
            uiTaskList.Items.Clear();

            try
            {
                var issues = await GetIssues();
                if (null == issues)
                    return;

                // Create list view groups from projects
                var projects = new HashSet<string>(issues.Select(i => i.FixedVersion?.Name ?? string.Empty));
                var groupsArray = projects.Select(i => new ListViewGroup(i, i)).ToArray();
                Array.Sort(groupsArray, new ListViewGroupSorter(SortOrder.Ascending));
                uiTaskList.Groups.AddRange(groupsArray);

                var issuesTotalTimeSpent = GetAllTotal();

                // Add issues to groups
                foreach (var item in issues)
                {
                    var timeSpent = issuesTotalTimeSpent.ContainsKey(item.Id) ? issuesTotalTimeSpent[item.Id] : new TimeSpan(0);

                    uiTaskList.Items.Add(new ListViewItem(new string[] { item.Id.ToString(), item.Status.Name, item.Subject, timeSpent.ToString() })
                    {
                        Name = item.Id.ToString(),
                        Tag = item.Id,
                        Group = uiTaskList.Groups[item.FixedVersion?.Name ?? string.Empty]
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Redmine access error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task<List<Issue>> GetIssues()
        {
            //parameter - get all issues
            var parameters = new NameValueCollection { { RedmineKeys.STATUS_ID, RedmineKeys.ALL } };

            //parameter - fetch my issues
            parameters.Add(RedmineKeys.ASSIGNED_TO_ID, "me");

            try
            {
                return await m_redmineManager.GetObjectsAsync<Issue>(parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Redmine access error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private IEnumerable<Session> GetAllSessions()
        {
            using (var cmd = m_dbconnection.CreateCommand())
            {
                cmd.CommandText = "SELECT issueId, sessionBegin, sessionEnd FROM timetracker ORDER BY issueId, sessionBegin;";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        yield return new Session(
                            (long)(double)reader["sessionBegin"],
                            (long)(double)reader["sessionEnd"],
                            (int)reader["issueId"]);
                    }
                }
            }
        }

        private Dictionary<int, TimeSpan> GetAllTotal()
        {
            var result = new Dictionary<int, TimeSpan>();
            using (var cmd = m_dbconnection.CreateCommand())
            {
                cmd.CommandText = "SELECT issueId, SUM(sessionEnd - sessionBegin) spent FROM timetracker GROUP BY issueId ORDER BY issueId;";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add((int)reader["issueId"], new TimeSpan((long)(double)reader["spent"]));
                    }
                }
            }
            return result;
        }

        private void uiUpdateIssues_Click(object sender, EventArgs e)
            => UpdateIssues();

        private void uibtnSettings_Click(object sender, EventArgs e)
        {
            var form = new FormSettings();
            form.Show(this);
            OpenDatabase(Properties.Settings.Default.DatabasePath);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseDatabase();
        }

        private void uiTaskList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            StopSession();
            StartSession();
        }

        private void uiStartStop_Click(object sender, EventArgs e)
        {
            if (m_activeIssueId != 0)
                StopSession();
            else if (uiTaskList.SelectedItems.Count > 0)
                StartSession();
        }

        private void StartSession()
        {
            if (m_activeIssueId == 0)
            {
                m_activeIssueId = (int)uiTaskList.SelectedItems[0].Tag;
                m_activeTotal = TimeSpan.Parse(uiTaskList.SelectedItems[0].SubItems[3].Text);
                m_activeSession = Session.Start();
                uibtnStartStop.Text = "Stop";
                m_activeSessionTimer = new Timer
                {
                    Interval = 1000
                };
                m_activeSessionTimer.Tick += (object sender, EventArgs e) => uiSessionTimer.Text = (m_activeTotal + m_activeSession.Duration).ToString();
                m_activeSessionTimer.Start();
            }
        }

        private void StopSession()
        {
            if (m_activeIssueId != 0)
            {
                m_activeSession.Stop();
                var lvItem = uiTaskList.Items.Find(m_activeIssueId.ToString(), false);
                lvItem[0].SubItems[3].Text = (m_activeTotal + m_activeSession.Duration).ToString();

                using (var cmd = m_dbconnection.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO timetracker VALUES (:id, :begin, :end);";
                    cmd.Parameters.AddWithValue(":id", m_activeIssueId);
                    cmd.Parameters.AddWithValue(":begin", m_activeSession.Begin.Ticks);
                    cmd.Parameters.AddWithValue(":end", m_activeSession.End.Ticks);
                    cmd.ExecuteNonQuery();
                }

                m_activeSessionTimer.Stop();
                m_activeSessionTimer = null;
                uibtnStartStop.Text = "Start";
                m_activeIssueId = 0;
                m_activeSession = null;
            }
        }

        private void uibtnReport_Click(object sender, EventArgs e)
        {
            var report = new FormReport(GetAllSessions().ToList());
            report.Show(this);
        }
    }
}
