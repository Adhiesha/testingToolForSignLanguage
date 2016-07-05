namespace CheckMateApp
{
    partial class SelfForm
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
            this.menuStrip1_self = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.wordQuizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1_self.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1_self
            // 
            this.menuStrip1_self.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStrip1_self.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.homeToolStripMenuItem,
            this.toolStripMenuItem2});
            this.menuStrip1_self.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1_self.Name = "menuStrip1_self";
            this.menuStrip1_self.Size = new System.Drawing.Size(834, 27);
            this.menuStrip1_self.TabIndex = 1;
            this.menuStrip1_self.Text = "menuStrip1";
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
            this.checkResultsToolStripMenuItem.Text = "Check Result";
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
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(173, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 300);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(315, 389);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 31);
            this.button4.TabIndex = 21;
            this.button4.Text = "Start Quiz";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // SelfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CheckMateApp.Properties.Resources.main_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1_self);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SelfForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelfForm";
            this.menuStrip1_self.ResumeLayout(false);
            this.menuStrip1_self.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1_self;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem wordQuizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem checkResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
    }
}