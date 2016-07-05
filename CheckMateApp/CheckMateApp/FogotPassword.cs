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
    public partial class FogotPassword : Form
    {
        public FogotPassword()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pbpSearch.Image = Resources.search2;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pbpSearch.Image = Resources.search1;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Login login = new Form_Login();
            login.Show();
            this.Hide();
        }
    }
}
