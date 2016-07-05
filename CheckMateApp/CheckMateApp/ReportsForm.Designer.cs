namespace CheckMateApp
{
    partial class ReportsForm
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
            this.menuStrip1_report = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.wordQuizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.menuStrip1_report.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1_report
            // 
            this.menuStrip1_report.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStrip1_report.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.homeToolStripMenuItem,
            this.toolStripMenuItem2});
            this.menuStrip1_report.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1_report.Name = "menuStrip1_report";
            this.menuStrip1_report.Size = new System.Drawing.Size(834, 27);
            this.menuStrip1_report.TabIndex = 2;
            this.menuStrip1_report.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.wordQuizToolStripMenuItem,
            this.toolStripMenuItem5,
            this.checkResultsToolStripMenuItem,
            this.checkReportToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripMenuItem1.Image = global::CheckMateApp.Properties.Resources.searchItem;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(78, 23);
            this.toolStripMenuItem1.Text = "Go To";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(169, 24);
            this.toolStripMenuItem4.Text = "Letter quiz";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // wordQuizToolStripMenuItem
            // 
            this.wordQuizToolStripMenuItem.Name = "wordQuizToolStripMenuItem";
            this.wordQuizToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.wordQuizToolStripMenuItem.Text = "Word quiz";
            this.wordQuizToolStripMenuItem.Click += new System.EventHandler(this.wordQuizToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(169, 24);
            this.toolStripMenuItem5.Text = "Sentence quiz";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // checkResultsToolStripMenuItem
            // 
            this.checkResultsToolStripMenuItem.Name = "checkResultsToolStripMenuItem";
            this.checkResultsToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.checkResultsToolStripMenuItem.Text = "Self quiz";
            this.checkResultsToolStripMenuItem.Click += new System.EventHandler(this.checkResultsToolStripMenuItem_Click);
            // 
            // checkReportToolStripMenuItem
            // 
            this.checkReportToolStripMenuItem.Name = "checkReportToolStripMenuItem";
            this.checkReportToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.checkReportToolStripMenuItem.Text = "Check Result";
            this.checkReportToolStripMenuItem.Click += new System.EventHandler(this.checkReportToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.homeToolStripMenuItem.Image = global::CheckMateApp.Properties.Resources.Home_icon;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(77, 23);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripMenuItem2.Image = global::CheckMateApp.Properties.Resources.LogOut;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(92, 23);
            this.toolStripMenuItem2.Text = "Log Out";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 27);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(834, 434);
            this.crystalReportViewer1.TabIndex = 3;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CheckMateApp.Properties.Resources.main_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.menuStrip1_report);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReportsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.menuStrip1_report.ResumeLayout(false);
            this.menuStrip1_report.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1_report;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem wordQuizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem checkResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}