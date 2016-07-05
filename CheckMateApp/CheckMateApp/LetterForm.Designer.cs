namespace CheckMateApp
{
    partial class LetterForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1_Letter = new System.Windows.Forms.MenuStrip();
            this.goTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordQuizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sentenceQuizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selfQuizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuizTimer = new System.Windows.Forms.Timer(this.components);
            this.lbltimerSet = new System.Windows.Forms.Label();
            this.lblLetterDisplay = new System.Windows.Forms.Label();
            this.lblget_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblshow_letter = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnq_10 = new System.Windows.Forms.Button();
            this.btnq_9 = new System.Windows.Forms.Button();
            this.btnq_8 = new System.Windows.Forms.Button();
            this.btnq_7 = new System.Windows.Forms.Button();
            this.btnq_6 = new System.Windows.Forms.Button();
            this.btnq_5 = new System.Windows.Forms.Button();
            this.btnq_4 = new System.Windows.Forms.Button();
            this.btnq_3 = new System.Windows.Forms.Button();
            this.btnq_2 = new System.Windows.Forms.Button();
            this.btnq_1 = new System.Windows.Forms.Button();
            this.menuStrip1_Letter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1_Letter
            // 
            this.menuStrip1_Letter.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStrip1_Letter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goTOToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1_Letter.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1_Letter.Name = "menuStrip1_Letter";
            this.menuStrip1_Letter.Size = new System.Drawing.Size(834, 27);
            this.menuStrip1_Letter.TabIndex = 1;
            this.menuStrip1_Letter.Text = "menuStrip1";
            // 
            // goTOToolStripMenuItem
            // 
            this.goTOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordQuizToolStripMenuItem,
            this.sentenceQuizToolStripMenuItem,
            this.selfQuizToolStripMenuItem,
            this.checkResultToolStripMenuItem,
            this.checkReportsToolStripMenuItem});
            this.goTOToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goTOToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.goTOToolStripMenuItem.Image = global::CheckMateApp.Properties.Resources.searchItem;
            this.goTOToolStripMenuItem.Name = "goTOToolStripMenuItem";
            this.goTOToolStripMenuItem.Size = new System.Drawing.Size(74, 23);
            this.goTOToolStripMenuItem.Text = "Go to";
            // 
            // wordQuizToolStripMenuItem
            // 
            this.wordQuizToolStripMenuItem.Name = "wordQuizToolStripMenuItem";
            this.wordQuizToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.wordQuizToolStripMenuItem.Text = "Word quiz";
            this.wordQuizToolStripMenuItem.Click += new System.EventHandler(this.wordQuizToolStripMenuItem_Click);
            // 
            // sentenceQuizToolStripMenuItem
            // 
            this.sentenceQuizToolStripMenuItem.Name = "sentenceQuizToolStripMenuItem";
            this.sentenceQuizToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.sentenceQuizToolStripMenuItem.Text = "Sentence quiz";
            this.sentenceQuizToolStripMenuItem.Click += new System.EventHandler(this.sentenceQuizToolStripMenuItem_Click);
            // 
            // selfQuizToolStripMenuItem
            // 
            this.selfQuizToolStripMenuItem.Name = "selfQuizToolStripMenuItem";
            this.selfQuizToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.selfQuizToolStripMenuItem.Text = "Self quiz";
            this.selfQuizToolStripMenuItem.Click += new System.EventHandler(this.selfQuizToolStripMenuItem_Click);
            // 
            // checkResultToolStripMenuItem
            // 
            this.checkResultToolStripMenuItem.Name = "checkResultToolStripMenuItem";
            this.checkResultToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.checkResultToolStripMenuItem.Text = "Check result";
            this.checkResultToolStripMenuItem.Click += new System.EventHandler(this.checkResultToolStripMenuItem_Click);
            // 
            // checkReportsToolStripMenuItem
            // 
            this.checkReportsToolStripMenuItem.Name = "checkReportsToolStripMenuItem";
            this.checkReportsToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.checkReportsToolStripMenuItem.Text = "Check reports";
            this.checkReportsToolStripMenuItem.Click += new System.EventHandler(this.checkReportsToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.settingToolStripMenuItem.Image = global::CheckMateApp.Properties.Resources.Home_icon;
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(77, 23);
            this.settingToolStripMenuItem.Text = "Home";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.logOutToolStripMenuItem.Image = global::CheckMateApp.Properties.Resources.LogOut;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(88, 23);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // QuizTimer
            // 
            this.QuizTimer.Interval = 1000;
            this.QuizTimer.Tick += new System.EventHandler(this.QuizTimer_Tick);
            // 
            // lbltimerSet
            // 
            this.lbltimerSet.AutoSize = true;
            this.lbltimerSet.BackColor = System.Drawing.Color.Transparent;
            this.lbltimerSet.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimerSet.Location = new System.Drawing.Point(356, 104);
            this.lbltimerSet.Name = "lbltimerSet";
            this.lbltimerSet.Size = new System.Drawing.Size(75, 26);
            this.lbltimerSet.TabIndex = 2;
            this.lbltimerSet.Text = "TIME";
            // 
            // lblLetterDisplay
            // 
            this.lblLetterDisplay.AutoSize = true;
            this.lblLetterDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblLetterDisplay.Font = new System.Drawing.Font("KaputaUnicode", 120F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetterDisplay.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblLetterDisplay.Location = new System.Drawing.Point(313, 182);
            this.lblLetterDisplay.Name = "lblLetterDisplay";
            this.lblLetterDisplay.Size = new System.Drawing.Size(165, 161);
            this.lblLetterDisplay.TabIndex = 22;
            this.lblLetterDisplay.Text = "-";
            // 
            // lblget_id
            // 
            this.lblget_id.AutoSize = true;
            this.lblget_id.BackColor = System.Drawing.Color.Transparent;
            this.lblget_id.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblget_id.Location = new System.Drawing.Point(730, 356);
            this.lblget_id.Name = "lblget_id";
            this.lblget_id.Size = new System.Drawing.Size(75, 26);
            this.lblget_id.TabIndex = 23;
            this.lblget_id.Text = "TIME";
            this.lblget_id.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(785, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "TIME";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(785, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "TIME";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(785, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "TIME";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(785, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "TIME";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(785, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "TIME";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(715, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "TIME";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(715, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 32;
            this.label8.Text = "TIME";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(715, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 31;
            this.label9.Text = "TIME";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(715, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 30;
            this.label10.Text = "TIME";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(715, 288);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 15);
            this.label11.TabIndex = 29;
            this.label11.Text = "TIME";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(356, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 26);
            this.label12.TabIndex = 34;
            this.label12.Text = "TIME";
            // 
            // lblshow_letter
            // 
            this.lblshow_letter.AutoSize = true;
            this.lblshow_letter.BackColor = System.Drawing.Color.Transparent;
            this.lblshow_letter.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshow_letter.Location = new System.Drawing.Point(356, 400);
            this.lblshow_letter.Name = "lblshow_letter";
            this.lblshow_letter.Size = new System.Drawing.Size(75, 26);
            this.lblshow_letter.TabIndex = 35;
            this.lblshow_letter.Text = "TIME";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnq_10);
            this.groupBox1.Controls.Add(this.btnq_9);
            this.groupBox1.Controls.Add(this.btnq_8);
            this.groupBox1.Controls.Add(this.btnq_7);
            this.groupBox1.Controls.Add(this.btnq_6);
            this.groupBox1.Controls.Add(this.btnq_5);
            this.groupBox1.Controls.Add(this.btnq_4);
            this.groupBox1.Controls.Add(this.btnq_3);
            this.groupBox1.Controls.Add(this.btnq_2);
            this.groupBox1.Controls.Add(this.btnq_1);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(71, 399);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // btnq_10
            // 
            this.btnq_10.BackColor = System.Drawing.Color.Transparent;
            this.btnq_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnq_10.ForeColor = System.Drawing.Color.Black;
            this.btnq_10.Location = new System.Drawing.Point(16, 362);
            this.btnq_10.Name = "btnq_10";
            this.btnq_10.Size = new System.Drawing.Size(34, 31);
            this.btnq_10.TabIndex = 46;
            this.btnq_10.Text = "10";
            this.btnq_10.UseVisualStyleBackColor = false;
            this.btnq_10.Click += new System.EventHandler(this.btnq_10_Click);
            // 
            // btnq_9
            // 
            this.btnq_9.BackColor = System.Drawing.Color.Transparent;
            this.btnq_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnq_9.ForeColor = System.Drawing.Color.Black;
            this.btnq_9.Location = new System.Drawing.Point(16, 325);
            this.btnq_9.Name = "btnq_9";
            this.btnq_9.Size = new System.Drawing.Size(34, 31);
            this.btnq_9.TabIndex = 45;
            this.btnq_9.Text = "9";
            this.btnq_9.UseVisualStyleBackColor = false;
            this.btnq_9.Click += new System.EventHandler(this.btnq_9_Click);
            // 
            // btnq_8
            // 
            this.btnq_8.BackColor = System.Drawing.Color.Transparent;
            this.btnq_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnq_8.ForeColor = System.Drawing.Color.Black;
            this.btnq_8.Location = new System.Drawing.Point(16, 289);
            this.btnq_8.Name = "btnq_8";
            this.btnq_8.Size = new System.Drawing.Size(34, 31);
            this.btnq_8.TabIndex = 44;
            this.btnq_8.Text = "8";
            this.btnq_8.UseVisualStyleBackColor = false;
            this.btnq_8.Click += new System.EventHandler(this.btnq_8_Click);
            // 
            // btnq_7
            // 
            this.btnq_7.BackColor = System.Drawing.Color.Transparent;
            this.btnq_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnq_7.ForeColor = System.Drawing.Color.Black;
            this.btnq_7.Location = new System.Drawing.Point(16, 252);
            this.btnq_7.Name = "btnq_7";
            this.btnq_7.Size = new System.Drawing.Size(34, 31);
            this.btnq_7.TabIndex = 43;
            this.btnq_7.Text = "7";
            this.btnq_7.UseVisualStyleBackColor = false;
            this.btnq_7.Click += new System.EventHandler(this.btnq_7_Click);
            // 
            // btnq_6
            // 
            this.btnq_6.BackColor = System.Drawing.Color.Transparent;
            this.btnq_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnq_6.ForeColor = System.Drawing.Color.Black;
            this.btnq_6.Location = new System.Drawing.Point(16, 215);
            this.btnq_6.Name = "btnq_6";
            this.btnq_6.Size = new System.Drawing.Size(34, 31);
            this.btnq_6.TabIndex = 42;
            this.btnq_6.Text = "6";
            this.btnq_6.UseVisualStyleBackColor = false;
            this.btnq_6.Click += new System.EventHandler(this.btnq_6_Click);
            // 
            // btnq_5
            // 
            this.btnq_5.BackColor = System.Drawing.Color.Transparent;
            this.btnq_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnq_5.ForeColor = System.Drawing.Color.Black;
            this.btnq_5.Location = new System.Drawing.Point(16, 178);
            this.btnq_5.Name = "btnq_5";
            this.btnq_5.Size = new System.Drawing.Size(34, 31);
            this.btnq_5.TabIndex = 41;
            this.btnq_5.Text = "5";
            this.btnq_5.UseVisualStyleBackColor = false;
            this.btnq_5.Click += new System.EventHandler(this.btnq_5_Click);
            // 
            // btnq_4
            // 
            this.btnq_4.BackColor = System.Drawing.Color.Transparent;
            this.btnq_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnq_4.ForeColor = System.Drawing.Color.Black;
            this.btnq_4.Location = new System.Drawing.Point(16, 141);
            this.btnq_4.Name = "btnq_4";
            this.btnq_4.Size = new System.Drawing.Size(34, 31);
            this.btnq_4.TabIndex = 40;
            this.btnq_4.Text = "4";
            this.btnq_4.UseVisualStyleBackColor = false;
            this.btnq_4.Click += new System.EventHandler(this.btnq_4_Click);
            // 
            // btnq_3
            // 
            this.btnq_3.BackColor = System.Drawing.Color.Transparent;
            this.btnq_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnq_3.ForeColor = System.Drawing.Color.Black;
            this.btnq_3.Location = new System.Drawing.Point(16, 104);
            this.btnq_3.Name = "btnq_3";
            this.btnq_3.Size = new System.Drawing.Size(34, 31);
            this.btnq_3.TabIndex = 39;
            this.btnq_3.Text = "3";
            this.btnq_3.UseVisualStyleBackColor = false;
            this.btnq_3.Click += new System.EventHandler(this.btnq_3_Click);
            // 
            // btnq_2
            // 
            this.btnq_2.BackColor = System.Drawing.Color.Transparent;
            this.btnq_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnq_2.ForeColor = System.Drawing.Color.Black;
            this.btnq_2.Location = new System.Drawing.Point(16, 67);
            this.btnq_2.Name = "btnq_2";
            this.btnq_2.Size = new System.Drawing.Size(34, 31);
            this.btnq_2.TabIndex = 38;
            this.btnq_2.Text = "2";
            this.btnq_2.UseVisualStyleBackColor = false;
            this.btnq_2.Click += new System.EventHandler(this.btnq_2_Click);
            // 
            // btnq_1
            // 
            this.btnq_1.BackColor = System.Drawing.Color.Transparent;
            this.btnq_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnq_1.ForeColor = System.Drawing.Color.Black;
            this.btnq_1.Location = new System.Drawing.Point(16, 30);
            this.btnq_1.Name = "btnq_1";
            this.btnq_1.Size = new System.Drawing.Size(34, 31);
            this.btnq_1.TabIndex = 37;
            this.btnq_1.Text = "1";
            this.btnq_1.UseVisualStyleBackColor = false;
            this.btnq_1.Click += new System.EventHandler(this.btnq_1_Click);
            // 
            // LetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CheckMateApp.Properties.Resources.main_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblshow_letter);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblget_id);
            this.Controls.Add(this.lblLetterDisplay);
            this.Controls.Add(this.lbltimerSet);
            this.Controls.Add(this.menuStrip1_Letter);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LetterForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Letter Testing";
            this.Load += new System.EventHandler(this.LetterForm_Load);
            this.menuStrip1_Letter.ResumeLayout(false);
            this.menuStrip1_Letter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1_Letter;
        private System.Windows.Forms.ToolStripMenuItem goTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordQuizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sentenceQuizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selfQuizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Timer QuizTimer;
        private System.Windows.Forms.Label lbltimerSet;
        private System.Windows.Forms.Label lblLetterDisplay;
        private System.Windows.Forms.Label lblget_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblshow_letter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnq_10;
        private System.Windows.Forms.Button btnq_9;
        private System.Windows.Forms.Button btnq_8;
        private System.Windows.Forms.Button btnq_7;
        private System.Windows.Forms.Button btnq_6;
        private System.Windows.Forms.Button btnq_5;
        private System.Windows.Forms.Button btnq_4;
        private System.Windows.Forms.Button btnq_3;
        private System.Windows.Forms.Button btnq_2;
        private System.Windows.Forms.Button btnq_1;

    }
}