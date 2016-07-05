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
    public partial class SentenceForm : Form
    {
        public SentenceForm()
        {
            InitializeComponent();
        }

       

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            LetterForm letter = new LetterForm();
            this.Hide();
            letter.Show();

        }

        private void wordQuizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WordForm word = new WordForm();
            this.Hide();
            word.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            SelfForm self = new SelfForm();
            this.Hide();
            self.Show();
        }

        private void checkResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultForm result = new ResultForm();
            this.Hide();
            result.Show();
        }

        private void checkReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportsForm report = new ReportsForm();
            this.Hide();
            report.Show();

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMainPage mainpage = new FormMainPage();
            this.Hide();
            mainpage.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form_Login logout = new Form_Login();
            this.Hide();
            logout.Show();
        }

       
    }
}
