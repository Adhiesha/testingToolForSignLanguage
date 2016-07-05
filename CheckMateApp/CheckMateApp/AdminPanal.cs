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
    public partial class AdminPanal : Form
    {
        public AdminPanal()
        {
            InitializeComponent();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMainPage main = new FormMainPage();
            this.Hide();
            main.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ManageUsers user = new ManageUsers();
            this.Hide();
            user.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AdminPassword adminpass = new AdminPassword();
            this.Hide();
            adminpass.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            BackUpForm backup = new BackUpForm();
            this.Hide();
            backup.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ReportForm report = new ReportForm();
            this.Hide();
            report.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            UserViewForm user = new UserViewForm();
            this.Hide();
            user.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ResultViewForm result = new ResultViewForm();
            this.Hide();
            result.Show();
        }
    }
}
