namespace RedmineTimeTracker
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.uiLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uiURL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uibtnSave = new System.Windows.Forms.Button();
            this.uibtnCancel = new System.Windows.Forms.Button();
            this.uiPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uiDatabasePath = new System.Windows.Forms.TextBox();
            this.uidlgOpenDatabase = new System.Windows.Forms.OpenFileDialog();
            this.uibtnOpenDatabase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // uiLogin
            // 
            this.uiLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLogin.Location = new System.Drawing.Point(56, 60);
            this.uiLogin.Name = "uiLogin";
            this.uiLogin.Size = new System.Drawing.Size(198, 20);
            this.uiLogin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "URL:";
            // 
            // uiURL
            // 
            this.uiURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiURL.Location = new System.Drawing.Point(56, 18);
            this.uiURL.Name = "uiURL";
            this.uiURL.Size = new System.Drawing.Size(471, 20);
            this.uiURL.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // uibtnSave
            // 
            this.uibtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uibtnSave.Location = new System.Drawing.Point(371, 154);
            this.uibtnSave.Name = "uibtnSave";
            this.uibtnSave.Size = new System.Drawing.Size(75, 23);
            this.uibtnSave.TabIndex = 6;
            this.uibtnSave.Text = "Save";
            this.uibtnSave.UseVisualStyleBackColor = true;
            this.uibtnSave.Click += new System.EventHandler(this.uibtnSave_Click);
            // 
            // uibtnCancel
            // 
            this.uibtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uibtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.uibtnCancel.Location = new System.Drawing.Point(452, 154);
            this.uibtnCancel.Name = "uibtnCancel";
            this.uibtnCancel.Size = new System.Drawing.Size(75, 23);
            this.uibtnCancel.TabIndex = 7;
            this.uibtnCancel.Text = "Cancel";
            this.uibtnCancel.UseVisualStyleBackColor = true;
            this.uibtnCancel.Click += new System.EventHandler(this.uibtnCancel_Click);
            // 
            // uiPassword
            // 
            this.uiPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiPassword.Location = new System.Drawing.Point(332, 60);
            this.uiPassword.Name = "uiPassword";
            this.uiPassword.PasswordChar = '*';
            this.uiPassword.Size = new System.Drawing.Size(194, 20);
            this.uiPassword.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Database:";
            // 
            // uiDatabasePath
            // 
            this.uiDatabasePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiDatabasePath.Location = new System.Drawing.Point(79, 97);
            this.uiDatabasePath.Name = "uiDatabasePath";
            this.uiDatabasePath.ReadOnly = true;
            this.uiDatabasePath.Size = new System.Drawing.Size(414, 20);
            this.uiDatabasePath.TabIndex = 10;
            // 
            // uidlgOpenDatabase
            // 
            this.uidlgOpenDatabase.DefaultExt = "db";
            this.uidlgOpenDatabase.Filter = "Redmine time tracker DB|*.db";
            // 
            // uibtnOpenDatabase
            // 
            this.uibtnOpenDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uibtnOpenDatabase.Location = new System.Drawing.Point(500, 95);
            this.uibtnOpenDatabase.Name = "uibtnOpenDatabase";
            this.uibtnOpenDatabase.Size = new System.Drawing.Size(26, 23);
            this.uibtnOpenDatabase.TabIndex = 11;
            this.uibtnOpenDatabase.Text = "...";
            this.uibtnOpenDatabase.UseVisualStyleBackColor = true;
            this.uibtnOpenDatabase.Click += new System.EventHandler(this.uibtnOpenDatabase_Click);
            // 
            // FormSettings
            // 
            this.AcceptButton = this.uibtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.uibtnCancel;
            this.ClientSize = new System.Drawing.Size(552, 194);
            this.Controls.Add(this.uibtnOpenDatabase);
            this.Controls.Add(this.uiDatabasePath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uiPassword);
            this.Controls.Add(this.uibtnCancel);
            this.Controls.Add(this.uibtnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uiURL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiLogin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormSettings";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uiLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uiURL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button uibtnSave;
        private System.Windows.Forms.Button uibtnCancel;
        private System.Windows.Forms.TextBox uiPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uiDatabasePath;
        private System.Windows.Forms.OpenFileDialog uidlgOpenDatabase;
        private System.Windows.Forms.Button uibtnOpenDatabase;
    }
}