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
    public partial class BackUpForm : Form
    {
        public BackUpForm()
        {
            InitializeComponent();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminPanal panal = new AdminPanal();
            this.Hide();
            panal.Show();
        }
    }
}
