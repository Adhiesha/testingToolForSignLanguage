namespace CheckMateApp
{
    partial class ResultForm
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
            this.menuStrip1_result = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.wordQuizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1_result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1_result
            // 
            this.menuStrip1_result.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStrip1_result.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.homeToolStripMenuItem,
            this.toolStripMenuItem2});
            this.menuStrip1_result.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1_result.Name = "menuStrip1_result";
            this.menuStrip1_result.Size = new System.Drawing.Size(834, 27);
            this.menuStrip1_result.TabIndex = 1;
            this.menuStrip1_result.Text = "menuStrip1";
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
            this.toolStripMenuItem4.Size = new System.Drawing.Size(172, 24);
            this.toolStripMenuItem4.Text = "Letter quiz";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // wordQuizToolStripMenuItem
            // 
            this.wordQuizToolStripMenuItem.Name = "wordQuizToolStripMenuItem";
            this.wordQuizToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.wordQuizToolStripMenuItem.Text = "Word quiz";
            this.wordQuizToolStripMenuItem.Click += new System.EventHandler(this.wordQuizToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(172, 24);
            this.toolStripMenuItem5.Text = "Sentence quiz";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // checkResultsToolStripMenuItem
            // 
            this.checkResultsToolStripMenuItem.Name = "checkResultsToolStripMenuItem";
            this.checkResultsToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.checkResultsToolStripMenuItem.Text = "Self quiz";
            this.checkResultsToolStripMenuItem.Click += new System.EventHandler(this.checkResultsToolStripMenuItem_Click);
            // 
            // checkReportToolStripMenuItem
            // 
            this.checkReportToolStripMenuItem.Name = "checkReportToolStripMenuItem";
            this.checkReportToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.checkReportToolStripMenuItem.Text = "Check Report";
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(752, 356);
            this.dataGridView1.TabIndex = 2;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CheckMateApp.Properties.Resources.main_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1_result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ResultForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result";
            this.menuStrip1_result.ResumeLayout(false);
            this.menuStrip1_result.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1_result;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem wordQuizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem checkResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.DataGridView dataGridView1;


    }
}