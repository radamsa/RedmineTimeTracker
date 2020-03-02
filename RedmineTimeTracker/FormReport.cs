using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedmineTimeTracker
{
    public partial class FormReport : Form
    {
        private List<Session> m_sessions;

        public FormReport(List<Session> sessions)
        {
            InitializeComponent();
            m_sessions = sessions;
            uiCalendar.MinDate = m_sessions.Min(i => i.Begin);
            uiCalendar.MaxDate = m_sessions.Max(i => i.End);
            var dates = new HashSet<DateTime>(m_sessions.Select(i => i.Begin.Date).Union(m_sessions.Select(i => i.End.Date)));
            uiCalendar.BoldedDates = dates.ToArray();

            UpdateReport(DateTime.Now);
        }

        private void uiCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            UpdateReport(e.Start);
        }

        private void UpdateReport(DateTime day)
        {
            uiSessionList.Items.Clear();
            foreach (var item in m_sessions
                .Where(i => (i.Begin >= day.Date && i.Begin <= day.AddDays(1)) || (i.End >= day && i.End <= day.AddDays(1))))
            {
                uiSessionList.Items.Add(new ListViewItem(new string[] {
                    item.IssueId.ToString(),
                    item.Begin.ToString(),
                    item.End.ToString(),
                    item.Duration.ToString() })
                {
                    Name = item.IssueId.ToString(),
                    Tag = item,
                });
            }
        }
    }
}
