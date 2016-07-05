namespace CheckMateApp
{
    partial class Form_Login
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
            this.App_name = new System.Windows.Forms.Label();
            this.txtlog_uname = new System.Windows.Forms.TextBox();
            this.Pb_user = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFogotPass = new System.Windows.Forms.Label();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.PbLogin = new System.Windows.Forms.PictureBox();
            this.PbExit = new System.Windows.Forms.PictureBox();
            this.txtlog_pass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // App_name
            // 
            this.App_name.AutoSize = true;
            this.App_name.BackColor = System.Drawing.Color.Transparent;
            this.App_name.Font = new System.Drawing.Font("Hobo Std", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.App_name.ForeColor = System.Drawing.Color.RoyalBlue;
            this.App_name.Location = new System.Drawing.Point(190, 22);
            this.App_name.Name = "App_name";
            this.App_name.Size = new System.Drawing.Size(279, 68);
            this.App_name.TabIndex = 0;
            this.App_name.Text = "CheckMate";
            // 
            // txtlog_uname
            // 
            this.txtlog_uname.AccessibleName = "";
            this.txtlog_uname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtlog_uname.Location = new System.Drawing.Point(233, 141);
            this.txtlog_uname.Multiline = true;
            this.txtlog_uname.Name = "txtlog_uname";
            this.txtlog_uname.Size = new System.Drawing.Size(214, 25);
            this.txtlog_uname.TabIndex = 1;
            this.txtlog_uname.Text = "UserName";
            this.txtlog_uname.Click += new System.EventHandler(this.TxtUsername_login_Click);
            this.txtlog_uname.TextChanged += new System.EventHandler(this.TxtUsername_login_TextChanged);
            // 
            // Pb_user
            // 
            this.Pb_user.BackColor = System.Drawing.Color.Transparent;
            this.Pb_user.Image = global::CheckMateApp.Properties.Resources.user;
            this.Pb_user.Location = new System.Drawing.Point(161, 124);
            this.Pb_user.Name = "Pb_user";
            this.Pb_user.Size = new System.Drawing.Size(55, 46);
            this.Pb_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_user.TabIndex = 3;
            this.Pb_user.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CheckMateApp.Properties.Resources._lock;
            this.pictureBox1.Location = new System.Drawing.Point(173, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblFogotPass
            // 
            this.lblFogotPass.AutoSize = true;
            this.lblFogotPass.BackColor = System.Drawing.Color.Transparent;
            this.lblFogotPass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFogotPass.Location = new System.Drawing.Point(239, 262);
            this.lblFogotPass.Name = "lblFogotPass";
            this.lblFogotPass.Size = new System.Drawing.Size(120, 19);
            this.lblFogotPass.TabIndex = 5;
            this.lblFogotPass.Text = "Fogot Passwod ?";
            this.lblFogotPass.Click += new System.EventHandler(this.lblFogotPass_Click);
            this.lblFogotPass.MouseLeave += new System.EventHandler(this.lblFogotPass_MouseLeave);
            this.lblFogotPass.MouseHover += new System.EventHandler(this.lblFogotPass_MouseHover);
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.BackColor = System.Drawing.Color.Transparent;
            this.lblSignUp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSignUp.Location = new System.Drawing.Point(365, 262);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(61, 19);
            this.lblSignUp.TabIndex = 6;
            this.lblSignUp.Text = "Sing Up";
            this.lblSignUp.Click += new System.EventHandler(this.lblSignUp_Click);
            this.lblSignUp.MouseLeave += new System.EventHandler(this.lblSignUp_MouseLeave);
            this.lblSignUp.MouseHover += new System.EventHandler(this.lblSignUp_MouseHover);
            // 
            // PbLogin
            // 
            this.PbLogin.BackColor = System.Drawing.Color.Transparent;
            this.PbLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbLogin.Image = global::CheckMateApp.Properties.Resources.log1;
            this.PbLogin.Location = new System.Drawing.Point(105, 330);
            this.PbLogin.Name = "PbLogin";
            this.PbLogin.Size = new System.Drawing.Size(222, 46);
            this.PbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbLogin.TabIndex = 7;
            this.PbLogin.TabStop = false;
            this.PbLogin.Click += new System.EventHandler(this.PbLogin_Click);
            this.PbLogin.MouseLeave += new System.EventHandler(this.PbLogin_MouseLeave);
            this.PbLogin.MouseHover += new System.EventHandler(this.PbLogin_MouseHover);
            // 
            // PbExit
            // 
            this.PbExit.BackColor = System.Drawing.Color.Transparent;
            this.PbExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbExit.Image = global::CheckMateApp.Properties.Resources.exit1;
            this.PbExit.Location = new System.Drawing.Point(333, 330);
            this.PbExit.Name = "PbExit";
            this.PbExit.Size = new System.Drawing.Size(242, 46);
            this.PbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbExit.TabIndex = 8;
            this.PbExit.TabStop = false;
            this.PbExit.Click += new System.EventHandler(this.PbExit_Click);
            this.PbExit.MouseLeave += new System.EventHandler(this.PbExit_MouseLeave);
            this.PbExit.MouseHover += new System.EventHandler(this.PbExit_MouseHover);
            // 
            // txtlog_pass
            // 
            this.txtlog_pass.Location = new System.Drawing.Point(233, 196);
            this.txtlog_pass.Name = "txtlog_pass";
            this.txtlog_pass.Size = new System.Drawing.Size(214, 26);
            this.txtlog_pass.TabIndex = 9;
            this.txtlog_pass.Text = "PassWord";
            this.txtlog_pass.UseSystemPasswordChar = true;
            this.txtlog_pass.Click += new System.EventHandler(this.txtlog_pass_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CheckMateApp.Properties.Resources.main_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.txtlog_pass);
            this.Controls.Add(this.PbExit);
            this.Controls.Add(this.PbLogin);
            this.Controls.Add(this.lblSignUp);
            this.Controls.Add(this.lblFogotPass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Pb_user);
            this.Controls.Add(this.txtlog_uname);
            this.Controls.Add(this.App_name);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form_Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.Pb_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label App_name;
        private System.Windows.Forms.TextBox txtlog_uname;
        private System.Windows.Forms.PictureBox Pb_user;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFogotPass;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.PictureBox PbLogin;
        private System.Windows.Forms.PictureBox PbExit;
        private System.Windows.Forms.TextBox txtlog_pass;
    }
}

