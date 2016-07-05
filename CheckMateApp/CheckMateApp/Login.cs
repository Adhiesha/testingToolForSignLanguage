using CheckMateApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheckMateApp
{
    public partial class Form_Login : Form
    {

        DBAccess db = new DBAccess();
        public Form_Login()
        {
            InitializeComponent();
        }

        private void TxtUsername_login_Click(object sender, EventArgs e)
        {
            txtlog_uname.Clear();
        }

        private void TxtPassword_login_Click(object sender, EventArgs e)
        {
           
        }

        private void lblSignUp_MouseHover(object sender, EventArgs e)
        {
            lblSignUp.ForeColor = Color.Red;
        }

        private void lblSignUp_MouseLeave(object sender, EventArgs e)
        {
            lblSignUp.ForeColor = Color.WhiteSmoke;
        }

        private void lblFogotPass_MouseHover(object sender, EventArgs e)
        {
            lblFogotPass.ForeColor = Color.Red;
        }

        private void lblFogotPass_MouseLeave(object sender, EventArgs e)
        {
            lblFogotPass.ForeColor = Color.WhiteSmoke;
        }

        private void PbLogin_MouseHover(object sender, EventArgs e)
        {
            PbLogin.Image = Resources.log2;
        }

        private void PbLogin_MouseLeave(object sender, EventArgs e)
        {
            PbLogin.Image = Resources.log1;
        }

        private void PbExit_MouseHover(object sender, EventArgs e)
        {
            PbExit.Image = Resources.exit2;
        }

        private void PbExit_MouseLeave(object sender, EventArgs e)
        {
            PbExit.Image = Resources.exit1;
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            FormSingUp singup = new FormSingUp();
            singup.Show();
            this.Hide();
        }

        private void lblFogotPass_Click(object sender, EventArgs e)
        {
            FogotPassword fogotpassword = new FogotPassword();
            fogotpassword.Show();
            this.Hide();
        }

        private void PbExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void PbLogin_Click(object sender, EventArgs e)
        {

            if (txtlog_uname.Text == "" || txtlog_pass.Text== "")
            {

                MessageBox.Show("Provide both Username and Password", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                bool loged = db.AuthenticateUser(txtlog_uname.Text.ToString(),txtlog_pass.Text.ToString());
                if (loged)
                {

                    db.SetSession(txtlog_uname.Text.ToString());
                    clear();
                    FormMainPage mainpage = new FormMainPage();
                    mainpage.Show();
                    this.Hide();
                }
                else
                {

                    MessageBox.Show("Invalied Username or Password", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear();

                }
            }
          
        }

        public void clear()
        {
            txtlog_pass.ResetText();
            txtlog_uname.ResetText();
        }

        private void txtlog_pass_Click(object sender, EventArgs e)
        {
            txtlog_pass.Clear();
        }

        private void TxtUsername_login_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
