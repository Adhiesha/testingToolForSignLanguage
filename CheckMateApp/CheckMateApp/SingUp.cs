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
    public partial class FormSingUp : Form
    {

        DBAccess db = new DBAccess();
        public FormSingUp()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Login login = new Form_Login();
            login.Show();
            this.Hide();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pbSingup.Image = Resources.register2;
        }

        private void pbSingup_MouseLeave(object sender, EventArgs e)
        {
            pbSingup.Image = Resources.register1;
        }

        private void pbSingup_Click(object sender, EventArgs e)
        {
            if (txtuname_s.Text == "" || txtpass_s.Text == "" || txtfname_s.Text == "" ||  txtlname_s.Text == "" ||cmb_s.SelectedItem == null ||txttelno_s.Text=="" || txtemail_s.Text=="" || txtnic_s.Text=="")
            {

                MessageBox.Show("please fill all the fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    db.addUser(txtuname_s.Text, txtpass_s.Text, txtfname_s.Text, txtlname_s.Text, cmb_s.SelectedItem.ToString(), txttelno_s.Text, txtemail_s.Text, txtnic_s.Text);
                    MessageBox.Show("user has been added!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleartxt();
                    Form_Login login = new Form_Login();
                    this.Hide();
                    login.Show();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }  
            }     
        }
        public void cleartxt()
        {
            txtuname_s.ResetText();
            txtpass_s.ResetText();
            txtfname_s.ResetText();
            txtlname_s.ResetText();
            cmb_s.ResetText();
            txttelno_s.ResetText();
            txtemail_s.ResetText();
            txtnic_s.ResetText();
        }

    }
}
