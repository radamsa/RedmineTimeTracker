﻿namespace RedmineTimeTracker
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.uiTaskList = new System.Windows.Forms.ListView();
            this.chdrId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdrStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdrSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdrTimeTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uiStatusStrip = new System.Windows.Forms.StatusStrip();
            this.uiStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.uiToolStrip = new System.Windows.Forms.ToolStrip();
            this.uibtnSignIn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.uibtnUpdateIssues = new System.Windows.Forms.ToolStripButton();
            this.uibtnSettings = new System.Windows.Forms.ToolStripButton();
            this.uibtnReport = new System.Windows.Forms.ToolStripButton();
            this.uiLabelTimeSpent = new System.Windows.Forms.ToolStripLabel();
            this.uiRightSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.uibtnStartStop = new System.Windows.Forms.ToolStripButton();
            this.uiRightSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.uiAddTime = new System.Windows.Forms.ToolStripButton();
            this.uiStatusStrip.SuspendLayout();
            this.uiToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiTaskList
            // 
            this.uiTaskList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiTaskList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chdrId,
            this.chdrStatus,
            this.chdrSubject,
            this.chdrTimeTotal});
            this.uiTaskList.FullRowSelect = true;
            this.uiTaskList.GridLines = true;
            this.uiTaskList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.uiTaskList.HideSelection = false;
            this.uiTaskList.Location = new System.Drawing.Point(0, 28);
            this.uiTaskList.MultiSelect = false;
            this.uiTaskList.Name = "uiTaskList";
            this.uiTaskList.Size = new System.Drawing.Size(827, 852);
            this.uiTaskList.TabIndex = 0;
            this.uiTaskList.UseCompatibleStateImageBehavior = false;
            this.uiTaskList.View = System.Windows.Forms.View.Details;
            this.uiTaskList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.uiTaskList_MouseDoubleClick);
            // 
            // chdrId
            // 
            this.chdrId.Text = "Id";
            this.chdrId.Width = 100;
            // 
            // chdrStatus
            // 
            this.chdrStatus.Text = "Status";
            this.chdrStatus.Width = 100;
            // 
            // chdrSubject
            // 
            this.chdrSubject.Text = "Subject";
            this.chdrSubject.Width = 500;
            // 
            // chdrTimeTotal
            // 
            this.chdrTimeTotal.Text = "Total time spent";
            this.chdrTimeTotal.Width = 100;
            // 
            // uiStatusStrip
            // 
            this.uiStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uiStripStatusLabel});
            this.uiStatusStrip.Location = new System.Drawing.Point(0, 858);
            this.uiStatusStrip.Name = "uiStatusStrip";
            this.uiStatusStrip.Size = new System.Drawing.Size(827, 22);
            this.uiStatusStrip.TabIndex = 1;
            // 
            // uiStripStatusLabel
            // 
            this.uiStripStatusLabel.Name = "uiStripStatusLabel";
            this.uiStripStatusLabel.Size = new System.Drawing.Size(16, 17);
            this.uiStripStatusLabel.Text = "...";
            // 
            // uiToolStrip
            // 
            this.uiToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uibtnSignIn,
            this.toolStripSeparator1,
            this.uibtnUpdateIssues,
            this.uibtnSettings,
            this.uibtnReport,
            this.uiLabelTimeSpent,
            this.uiRightSeparator2,
            this.uibtnStartStop,
            this.uiRightSeparator1,
            this.toolStripButton1,
            this.uiAddTime});
            this.uiToolStrip.Location = new System.Drawing.Point(0, 0);
            this.uiToolStrip.Name = "uiToolStrip";
            this.uiToolStrip.Size = new System.Drawing.Size(827, 25);
            this.uiToolStrip.TabIndex = 2;
            this.uiToolStrip.Text = "toolStrip1";
            // 
            // uibtnSignIn
            // 
            this.uibtnSignIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.uibtnSignIn.Image = ((System.Drawing.Image)(resources.GetObject("uibtnSignIn.Image")));
            this.uibtnSignIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uibtnSignIn.Name = "uibtnSignIn";
            this.uibtnSignIn.Size = new System.Drawing.Size(44, 22);
            this.uibtnSignIn.Text = "SignIn";
            this.uibtnSignIn.Click += new System.EventHandler(this.uibtnSignIn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // uibtnUpdateIssues
            // 
            this.uibtnUpdateIssues.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.uibtnUpdateIssues.Image = ((System.Drawing.Image)(resources.GetObject("uibtnUpdateIssues.Image")));
            this.uibtnUpdateIssues.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uibtnUpdateIssues.Name = "uibtnUpdateIssues";
            this.uibtnUpdateIssues.Size = new System.Drawing.Size(83, 22);
            this.uibtnUpdateIssues.Text = "Update issues";
            this.uibtnUpdateIssues.ToolTipText = "Update issues";
            this.uibtnUpdateIssues.Visible = false;
            this.uibtnUpdateIssues.Click += new System.EventHandler(this.uiUpdateIssues_Click);
            // 
            // uibtnSettings
            // 
            this.uibtnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.uibtnSettings.Image = ((System.Drawing.Image)(resources.GetObject("uibtnSettings.Image")));
            this.uibtnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uibtnSettings.Name = "uibtnSettings";
            this.uibtnSettings.Size = new System.Drawing.Size(53, 22);
            this.uibtnSettings.Text = "Settings";
            this.uibtnSettings.Click += new System.EventHandler(this.uibtnSettings_Click);
            // 
            // uibtnReport
            // 
            this.uibtnReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.uibtnReport.Image = ((System.Drawing.Image)(resources.GetObject("uibtnReport.Image")));
            this.uibtnReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uibtnReport.Name = "uibtnReport";
            this.uibtnReport.Size = new System.Drawing.Size(46, 22);
            this.uibtnReport.Text = "Report";
            this.uibtnReport.Click += new System.EventHandler(this.uibtnReport_Click);
            // 
            // uiLabelTimeSpent
            // 
            this.uiLabelTimeSpent.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.uiLabelTimeSpent.Name = "uiLabelTimeSpent";
            this.uiLabelTimeSpent.Size = new System.Drawing.Size(226, 22);
            this.uiLabelTimeSpent.Text = "Time spent: 00:00:00, last session: 00:00:00";
            this.uiLabelTimeSpent.Visible = false;
            // 
            // uiRightSeparator2
            // 
            this.uiRightSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.uiRightSeparator2.Name = "uiRightSeparator2";
            this.uiRightSeparator2.Size = new System.Drawing.Size(6, 25);
            this.uiRightSeparator2.Visible = false;
            // 
            // uibtnStartStop
            // 
            this.uibtnStartStop.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.uibtnStartStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.uibtnStartStop.Image = ((System.Drawing.Image)(resources.GetObject("uibtnStartStop.Image")));
            this.uibtnStartStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uibtnStartStop.Name = "uibtnStartStop";
            this.uibtnStartStop.Size = new System.Drawing.Size(35, 22);
            this.uibtnStartStop.Text = "Start";
            this.uibtnStartStop.ToolTipText = "Start/Stop";
            this.uibtnStartStop.Visible = false;
            this.uibtnStartStop.Click += new System.EventHandler(this.uiStartStop_Click);
            // 
            // uiRightSeparator1
            // 
            this.uiRightSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.uiRightSeparator1.Name = "uiRightSeparator1";
            this.uiRightSeparator1.Size = new System.Drawing.Size(6, 25);
            this.uiRightSeparator1.Visible = false;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Decrease time spent";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // uiAddTime
            // 
            this.uiAddTime.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.uiAddTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uiAddTime.Image = ((System.Drawing.Image)(resources.GetObject("uiAddTime.Image")));
            this.uiAddTime.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uiAddTime.Name = "uiAddTime";
            this.uiAddTime.Size = new System.Drawing.Size(23, 22);
            this.uiAddTime.Text = "toolStripButton1";
            this.uiAddTime.ToolTipText = "Increase time spent";
            this.uiAddTime.Click += new System.EventHandler(this.uiAddTime_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 880);
            this.Controls.Add(this.uiToolStrip);
            this.Controls.Add(this.uiStatusStrip);
            this.Controls.Add(this.uiTaskList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Redmine time tracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.uiStatusStrip.ResumeLayout(false);
            this.uiStatusStrip.PerformLayout();
            this.uiToolStrip.ResumeLayout(false);
            this.uiToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView uiTaskList;
        private System.Windows.Forms.StatusStrip uiStatusStrip;
        private System.Windows.Forms.ToolStrip uiToolStrip;
        private System.Windows.Forms.ToolStripButton uibtnSignIn;
        private System.Windows.Forms.ColumnHeader chdrId;
        private System.Windows.Forms.ColumnHeader chdrStatus;
        private System.Windows.Forms.ColumnHeader chdrSubject;
        private System.Windows.Forms.ColumnHeader chdrTimeTotal;
        private System.Windows.Forms.ToolStripStatusLabel uiStripStatusLabel;
        private System.Windows.Forms.ToolStripButton uibtnUpdateIssues;
        private System.Windows.Forms.ToolStripButton uibtnSettings;
        private System.Windows.Forms.ToolStripButton uibtnStartStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton uibtnReport;
        private System.Windows.Forms.ToolStripLabel uiLabelTimeSpent;
        private System.Windows.Forms.ToolStripSeparator uiRightSeparator2;
        private System.Windows.Forms.ToolStripSeparator uiRightSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton uiAddTime;
    }
}

