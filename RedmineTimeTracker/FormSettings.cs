using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedmineTimeTracker
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();

            uiURL.Text = Properties.Settings.Default.URL;
            uiLogin.Text = Properties.Settings.Default.Login;
            uiPassword.Text = Properties.Settings.Default.Password;
            uiDatabasePath.Text = Properties.Settings.Default.DatabasePath;
        }

        private void uibtnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.URL = uiURL.Text;
            Properties.Settings.Default.Login = uiLogin.Text;
            Properties.Settings.Default.Password = uiPassword.Text;
            Properties.Settings.Default.DatabasePath = uiDatabasePath.Text;
            Properties.Settings.Default.Save();
            Close();
        }

        private void uibtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uibtnOpenDatabase_Click(object sender, EventArgs e)
        {
            uidlgOpenDatabase.InitialDirectory = Path.GetDirectoryName(uiDatabasePath.Text);
            if (string.IsNullOrWhiteSpace(uidlgOpenDatabase.InitialDirectory))
                uidlgOpenDatabase.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;

            uidlgOpenDatabase.FileName = uiDatabasePath.Text;
            if (uidlgOpenDatabase.ShowDialog() == DialogResult.OK)
                uiDatabasePath.Text = uidlgOpenDatabase.FileName;
        }
    }
}
