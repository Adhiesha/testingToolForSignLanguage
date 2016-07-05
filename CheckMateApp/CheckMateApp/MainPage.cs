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
    public partial class FormMainPage : Form
    {
        public FormMainPage()
        {
            InitializeComponent();
        }

        private void pbmainLetter_MouseHover(object sender, EventArgs e)
        {
            pbmainLetter.Image = Resources.letter2;
        }

        private void pbmainLetter_MouseLeave(object sender, EventArgs e)
        {
            pbmainLetter.Image = Resources.letter1;
        }

        private void pbmainWord_MouseHover(object sender, EventArgs e)
        {
            pbmainWord.Image = Resources.word2;
        }

        private void pbmainWord_MouseLeave(object sender, EventArgs e)
        {
            pbmainWord.Image = Resources.word1;
        }

        private void pbmainSentence_MouseHover(object sender, EventArgs e)
        {
            pbmainSentence.Image = Resources.sentence2;
        }

        private void pbmainSentence_MouseLeave(object sender, EventArgs e)
        {
            pbmainSentence.Image = Resources.sentence1;
        }

        private void pbmainSelftest_MouseHover(object sender, EventArgs e)
        {
            pbmainSelftest.Image = Resources.selfTest2;
        }

        private void pbmainSelftest_MouseLeave(object sender, EventArgs e)
        {
            pbmainSelftest.Image = Resources.selfTest1;
        }

        private void pbmainresult_MouseHover(object sender, EventArgs e)
        {
            pbmainresult.Image = Resources.result2;
        }

        private void pbmainresult_MouseLeave(object sender, EventArgs e)
        {
            pbmainresult.Image = Resources.result1;
        }

        private void pbmainReport_MouseHover(object sender, EventArgs e)
        {
            pbmainReport.Image = Resources.report2;
        }

        private void pbmainReport_MouseLeave(object sender, EventArgs e)
        {
            pbmainReport.Image = Resources.report1;
        }

        private void pbmainLetter_Click(object sender, EventArgs e)
        {
            LetterForm letter = new LetterForm();
            this.Hide();
            letter.Show();
        }

        private void pbmainWord_Click(object sender, EventArgs e)
        {
            WordForm word = new WordForm();
            this.Hide();
            word.Show();

        }

        private void pbmainSentence_Click(object sender, EventArgs e)
        {
            SentenceForm sentence = new SentenceForm();
            this.Hide();
            sentence.Show();
        }

        private void pbmainSelftest_Click(object sender, EventArgs e)
        {
            SelfForm self = new SelfForm();
            this.Hide();
            self.Show();
        }

        private void pbmainresult_Click(object sender, EventArgs e)
        {
            ResultForm result = new ResultForm();
            this.Hide();
            result.Show();
        }

        private void pbmainReport_Click(object sender, EventArgs e)
        {
            ReportsForm report = new ReportsForm();
            this.Hide();
            report.Show();
        }

        private void letterQuizToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void sentenceQuizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SentenceForm sentence = new SentenceForm();
            this.Hide();
            sentence.Show();
        }

        private void selfQuizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelfForm self = new SelfForm();
            this.Hide();
            self.Show();
        }

        private void checkResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultForm result = new ResultForm();
            this.Hide();
            result.Show();
        }

        private void checkReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportsForm report = new ReportsForm();
            this.Hide();
            report.Show();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Session.logedInType.ToString() == "admin")
            {
                AdminPanal admin = new AdminPanal();
                this.Hide();
                admin.Show();
            }
            else
            {
                MessageBox.Show("You do not have permissions", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs about = new AboutUs();
            this.Hide();
            about.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Login logout = new Form_Login();
            this.Hide();
            logout.Show();

        }


       
        
    }
}
