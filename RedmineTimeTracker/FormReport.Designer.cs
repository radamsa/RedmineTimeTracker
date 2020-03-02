namespace RedmineTimeTracker
{
    partial class FormReport
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
            this.uiCalendar = new System.Windows.Forms.MonthCalendar();
            this.uiSessionList = new System.Windows.Forms.ListView();
            this.chdrsSessionBegin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdrSessionEnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdrSessionTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdrIssueId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // uiCalendar
            // 
            this.uiCalendar.Location = new System.Drawing.Point(12, 18);
            this.uiCalendar.Name = "uiCalendar";
            this.uiCalendar.TabIndex = 0;
            // 
            // uiSessionList
            // 
            this.uiSessionList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiSessionList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chdrIssueId,
            this.chdrsSessionBegin,
            this.chdrSessionEnd,
            this.chdrSessionTime});
            this.uiSessionList.GridLines = true;
            this.uiSessionList.HideSelection = false;
            this.uiSessionList.Location = new System.Drawing.Point(12, 185);
            this.uiSessionList.Name = "uiSessionList";
            this.uiSessionList.Size = new System.Drawing.Size(668, 726);
            this.uiSessionList.TabIndex = 3;
            this.uiSessionList.UseCompatibleStateImageBehavior = false;
            this.uiSessionList.View = System.Windows.Forms.View.Details;
            // 
            // chdrsSessionBegin
            // 
            this.chdrsSessionBegin.Text = "Session begin";
            this.chdrsSessionBegin.Width = 150;
            // 
            // chdrSessionEnd
            // 
            this.chdrSessionEnd.Text = "Session end";
            this.chdrSessionEnd.Width = 150;
            // 
            // chdrSessionTime
            // 
            this.chdrSessionTime.Text = "Session time";
            this.chdrSessionTime.Width = 150;
            // 
            // chdrIssueId
            // 
            this.chdrIssueId.Text = "Issue id";
            this.chdrIssueId.Width = 100;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 926);
            this.Controls.Add(this.uiSessionList);
            this.Controls.Add(this.uiCalendar);
            this.Name = "FormReport";
            this.Text = "Time report";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar uiCalendar;
        private System.Windows.Forms.ListView uiSessionList;
        private System.Windows.Forms.ColumnHeader chdrIssueId;
        private System.Windows.Forms.ColumnHeader chdrsSessionBegin;
        private System.Windows.Forms.ColumnHeader chdrSessionEnd;
        private System.Windows.Forms.ColumnHeader chdrSessionTime;
    }
}