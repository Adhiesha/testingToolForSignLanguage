using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Leap;

namespace CheckMateApp
{
    public partial class LetterForm : Form
    {
        List<string> letterList = new List<string>();
        DBAccess db = new DBAccess();
        int marks = 0;
        int qno = 0;
        bool check_true = true;
        public LetterForm()
        {
            InitializeComponent();

            using (Controller controller = new Controller())
            {

              
                controller.FrameReady += newFrameHandler;

            }
        }


        
        private void newFrameHandler(object sender, FrameEventArgs e)
        {
           
            Boolean Thumb = false;
            Boolean Index = false;
            Boolean Middle = false;
            Boolean Ring = false;
            Boolean Pinky = false;
            Frame frameval = e.frame;


         
            foreach (Hand hand in frameval.Hands)
            {
                Finger g1 = hand.Fingers[0];
                Finger g2 = hand.Fingers[1];
                Finger g3 = hand.Fingers[2];
                Finger g4 = hand.Fingers[3];
                Finger g5 = hand.Fingers[4];
      
                double a1=Convert.ToDouble(Math.Round(g1.Direction.Yaw,2));
                double a2 = Convert.ToDouble(Math.Round(g2.Direction.Yaw, 2));
                double a3 = Convert.ToDouble(Math.Round(g3.Direction.Yaw, 2));
                double a4 = Convert.ToDouble(Math.Round(g4.Direction.Yaw, 2));
                double a5 = Convert.ToDouble(Math.Round(g5.Direction.Yaw, 2));
                for (int i = 0; i < hand.Fingers.Count; i++)
                {
                    Finger fingerData = hand.Fingers[i];
                    if (fingerData.IsExtended)
                    {
                        if (fingerData.Type == Finger.FingerType.TYPE_THUMB)
                        {
                            Thumb = true;
                        }
                        else if (fingerData.Type == Finger.FingerType.TYPE_INDEX)
                        {
                            Index = true;
                        }
                        else if (fingerData.Type == Finger.FingerType.TYPE_MIDDLE)
                        {
                            Middle = true;
                        }
                        else if (fingerData.Type == Finger.FingerType.TYPE_RING)
                        {
                            Ring = true;
                        }
                        else if (fingerData.Type == Finger.FingerType.TYPE_PINKY)
                        {
                            Pinky = true;
                        }
                    }    
                }
                label2.Text = a1.ToString();
                label3.Text = a2.ToString();
                label4.Text = a3.ToString();
                label5.Text = a4.ToString();
                label6.Text = a5.ToString();
                label7.Text = g1.IsExtended.ToString();
                label8.Text = g2.IsExtended.ToString();
                label9.Text = g3.IsExtended.ToString();
                label10.Text = g4.IsExtended.ToString();
                label11.Text = g5.IsExtended.ToString();
                checkletter(Thumb,Index,Middle,Ring,Pinky,a1,a2,a3,a4,a5);
            }
        }
        public void checkletter(bool v1, bool v2, bool v3, bool v4, bool v5, double a1, double a2, double a3, double a4, double a5)
        {
            if (lblget_id.Text == "1" && check_true==true)
            {
               // if (v1 == true && v2 == true && v3 == true && v4 == true && v5 == true) //&& a1 < -0.01 && a1 > -1.00 && a2 > -0.01 && a2 < 1 && a3 > -0.01 && a3 < 1.00 && a4 > -0.01 && a4 < 1.00 && a5 > -0.01 && a5 < 1)
                if (v1 == true && v2 == true && v3 == true && v4 == true && v5 == true && a1 < -0.01 && a1 > -0.40 && a2 > -0.05 && a2 < 0.15 && a3 > -0.02 && a3 < 0.2 && a4 > -0.01 && a4 < 0.2 && a5 > -0.04 && a5 < 0.2)
                {
                    DataSet ds = db.FindLetter(1);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        check_true = false;
                        string letget = ds.Tables[0].Rows[0][1].ToString();
                        lblshow_letter.Text = "Letter    :   " + letget + ": Match";
                        btnq_1.BackColor = Color.MediumSeaGreen;
                        btnq_1.Enabled = false;
                        marks++;
                    }
                } 
                else
                {
                    if (check_true == true)
                    {
                        btnq_1.BackColor = Color.Red;
                    }
                }
            }

            else if (lblget_id.Text == "2" && check_true==true)
            {
                if (v1 == true && v2 == false && v3 == false && v4 == false && v5 == false && a1 > -2 && a1 < -0.05 && a2 > -2.00 && a2 < -1.00 && a3 > -2.00 && a3 < -1.00 && a4 > -2.00 && a4 < -1.00 && a5 > -2.00 && a5 < -1.00)
                {
                    DataSet ds = db.FindLetter(2);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        check_true = false;
                        btnq_2.BackColor = Color.MediumSeaGreen;
                        btnq_2.Enabled = false;
                        string letget = ds.Tables[0].Rows[0][1].ToString();
                        lblshow_letter.Text = "Letter     :   " + letget + ": Match";
                        marks++;
                    }
                }
                else
                {
                    if (check_true == true)
                    {
                        btnq_2.BackColor = Color.Red;
                       
                    }
                }
            }
            else if (lblget_id.Text == "3" && check_true==true)
            {
                if (v1 == false && v2 == false && v3 == false && v4 == false && v5 == false && a1 > 0.01 && a1 < 1.00 && a2 > 2.70 && a2 < 3.10 && a3 > -3.2 && a3 < -2.70 && a4 > -3.00 && a4 < -2.30 && a5 > -2.8 && a5 < -2.3)
                {
                    DataSet ds = db.FindLetter(3);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        check_true = false;
                        btnq_3.BackColor = Color.MediumSeaGreen;
                        btnq_3.Enabled = false;
                        string letget = ds.Tables[0].Rows[0][1].ToString();
                        lblshow_letter.Text = "Letter     :   " + letget + ": Match";
                        marks++;
                    }
                }
                else
                {
                    if (check_true == true)
                    {
                        btnq_3.BackColor = Color.Red;
                    }
                }
            }
            else if (lblget_id.Text == "4" && check_true==true)
            {
                if (v1 == false && v2 == true && v3 == true && v4 == true && v5 == true && a2 > -0.05 && a2 < 0.15 && a3 > -0.02 && a3 < 0.2 && a4 > -0.01 && a4 < 0.2 && a5 > -0.04 && a5 < 0.2)
                {
                    DataSet ds = db.FindLetter(4);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        check_true = false;
                        btnq_4.BackColor = Color.MediumSeaGreen;
                        btnq_4.Enabled = false;
                        string letget = ds.Tables[0].Rows[0][1].ToString();
                        lblshow_letter.Text = "Letter     :  " + letget + ": Match";
                        marks++;
                    }
                }
                else
                {
                    if (check_true == true)
                    {
                        btnq_4.BackColor = Color.Red;
                    }
                }
            }
            else if (lblget_id.Text == "5" && check_true==true)
            {
                if (v1 == true && v2 == true && v3 == false && v4 == false && v5 == false && a1 > -1.5 && a1 < -0.4 && a2 > -0.01 && a2 < 1.00 && a3 > -3.2 && a3 < 3.1 && a4 > -3.2 && a4 < 3.1 && a5 > -3.2 && a5 < 3.2)
                {
                    DataSet ds = db.FindLetter(5);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        check_true = false;
                        btnq_5.BackColor = Color.MediumSeaGreen;
                        btnq_5.Enabled = false;
                        string letget = ds.Tables[0].Rows[0][1].ToString();
                        lblshow_letter.Text = "Letter     :  " + letget + ": Match";
                        marks++;
                    }
                }
                else
                {
                    if (check_true == true)
                    {
                        btnq_5.BackColor = Color.Red;
                    }
                }
            }
            else if (lblget_id.Text == "6" && check_true==true)
            {
                if (v1 == true && v2 == false && v3 == false && v4 == false && v5 == true && a1 > -0.80 && a1 < 1 && a2 > -2.80 && a2 < 3.2 && a3 > -3.1 && a3 < -2.00 && a4 > -3.1 && a4 < -2.5 && a5 > -0.01 && a5 < 2 )
                {
                    DataSet ds = db.FindLetter(6);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        check_true = false;
                        btnq_6.BackColor = Color.MediumSeaGreen;
                        btnq_6.Enabled = false;
                        string letget = ds.Tables[0].Rows[0][1].ToString();
                        lblshow_letter.Text = "Letter    :  " + letget + ": Match";
                        marks++;
                    }
                }
                else
                {
                    if (check_true == true)
                    {
                        btnq_6.BackColor = Color.Red;
                    }
                }
            }
            else if (lblget_id.Text == "7" && check_true==true)
            {
                if (v1 == false && v2 == true && v3 == true && v4 == false && v5 == false && a1 > -0.01 && a1 < 2 && a2 > -0.02 && a2 < 1 && a3 > -0.02 && a3 < 1 && a4 > -3 && a4 < 3 && a5 > -3 && a5 < 3.2)
                {
                    DataSet ds = db.FindLetter(7);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        check_true = false;
                        btnq_7.BackColor = Color.MediumSeaGreen;
                        btnq_7.Enabled = false;
                        string letget = ds.Tables[0].Rows[0][1].ToString();
                        lblshow_letter.Text = "Letter    :  " + letget + ": Match";
                        marks++;
                    }
                }
                else
                {
                    if (check_true == true)
                    {
                        btnq_7.BackColor = Color.Red;                     
                    }
                }
            }
            else if (lblget_id.Text == "8" && check_true==true)
            {
                if (v1 == true && v2 == true && v3 == false && v4 == false && v5 == false && a1 > -1.5 && a1 < -0.4 && a2 > -0.01 && a2 < 1.00 && a3 > -3.2 && a3 < 3.1 && a4 > -3.2 && a4 < 3.1 && a5 > -3.2 && a5 < 3.2)
                {
                    DataSet ds = db.FindLetter(8);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        check_true = false;
                        btnq_8.BackColor = Color.MediumSeaGreen;
                        btnq_8.Enabled = false;
                        string letget = ds.Tables[0].Rows[0][1].ToString();
                        lblshow_letter.Text = "Letter    :  " + letget + ": Match";
                        marks++;
                    }
                }
                else
                {
                    if (check_true == true)
                    {
                        btnq_8.BackColor = Color.Red;               
                    }
                }     
            } 
            else if (lblget_id.Text == "9" && check_true==true)
            {
                if (v1 == false && v2 == true && v3 == false && v4 == false && v5 == false && a1 > 0.01 && a1 < 1.00 && a2 > 0.02 && a2 < 1 && a3 > -3.2 && a3 < -2.70 && a4 > -3.00 && a4 < -2.30 && a5 > -2.8 && a5 < -2.3)
                {
                    DataSet ds = db.FindLetter(9);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        check_true = false;
                        btnq_9.BackColor = Color.MediumSeaGreen;
                        btnq_9.Enabled = false;
                        string letget = ds.Tables[0].Rows[0][1].ToString();
                        lblshow_letter.Text = "Letter    :  " + letget + ": Match";
                        marks++;
                    }
                }
                else
                {
                    if (check_true == true)
                    {
                        btnq_9.BackColor = Color.Red;                     
                    }
                }  
            }

           else if (lblget_id.Text == "10" && check_true==true)
            {
                if (v1 == false && v2 == true && v3 == true && v4 == true && v5 == false ) //&& a1 < -0.01 && a1 > -1.00 && a2 > -0.01 && a2 < 1 && a3 > -0.01 && a3 < 1.00 && a4 > -0.01 && a4 < 1.00 && a5 > -0.01 && a5 < 1)
                //if (v1 == true && v2 == true && v3 == true && v4 == true && v5 == true && a1 < -0.01 && a1 > -0.40 && a2 > -0.05 && a2 < 0.15 && a3 > -0.02 && a3 < 0.2 && a4 > -0.01 && a4 < 0.2 && a5 > -0.04 && a5 < 0.2)
                {
                    DataSet ds = db.FindLetter(10);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        check_true = false;
                        btnq_10.BackColor = Color.MediumSeaGreen;
                        btnq_10.Enabled = false;
                        string letget = ds.Tables[0].Rows[0][1].ToString();
                        lblshow_letter.Text = "Letter    :  " + letget + ": Match";
                        marks++;
                    }
                }
                else
                {
                    if (check_true == true)
                    {
                        btnq_10.BackColor = Color.Red;   
                    }
                }
            }
        }
        //&& a1 > -0.01 && a1 < 0.2 && a2 > -0.01 && a2 < 2 && a3 > .50 && a3 < 3.20
        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMainPage mainpage = new FormMainPage();
            this.Hide();
            mainpage.Show();
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


        private void LetterForm_Load(object sender, EventArgs e)
        {
            QuizTimer.Enabled = true;
            QuizTimer.Start();
            //btnq_1.PerformClick();
        }

        int duration = 50;
        private void QuizTimer_Tick(object sender, EventArgs e)
        {

            duration--;
            if (duration == 10)
            {
                lbltimerSet.ForeColor = Color.Red;

            }
            if (duration == 0)
            {
                QuizTimer.Stop();
                int qmarks = Convert.ToInt16(marks);
                DateTime today = DateTime.Now;
                string current = today.ToString("MM/dd/yyyy");
                string getMarks=Session.logedInType.ToString();
                int cal=qmarks*10;
                string qmark = "" + cal + "";
                try
                {
                    db.marksAdd(getMarks, qmark, qmarks);
                    MessageBox.Show("Your marks is   :" +cal+ "   successfuly added to the database......");
                    FormMainPage log = new FormMainPage();
                    this.Hide();
                    log.Show();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
               

            }

            lbltimerSet.Text = duration.ToString();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            QuizTimer.Enabled = true;
            QuizTimer.Start();
           // Recall_Letter(string.Empty);
        }

        public void show(double i1, double i2, double i3, double i4, double i5)
        {

            //label1.Text = i1.ToString();
            //label2.Text = i2.ToString();
            //label3.Text = i3.ToString();
            //label4.Text = i4.ToString();
            //label5.Text = i5.ToString();

            //label1.Text = ii.ToString();

            //if (i1 < -0.10 && i1 > -0.50 && i2 < -0.10 && i2 > -0.50 && i3 < -0.10 && i3 > -0.50 && i4 < -0.10 && i4 > -0.50 && i5 < -0.10 && i5 > -0.50)
            //{
            //    label1.Enabled = false;
            //    label2.Text = "A";
                
            //}
           
        }
        
        public int Recall_Letter(int qNo)
        {
              DataSet ds = db.FindLetter(Convert.ToInt16(qNo));
              if (ds.Tables[0].Rows.Count > 0)
              {
                  lblget_id.Text = ds.Tables[0].Rows[0][0].ToString();
                  lblLetterDisplay.Text = ds.Tables[0].Rows[0][1].ToString();
              }
              return -1;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Login logout = new Form_Login();
            this.Hide();
            logout.Show();
        }

        private void btnq_1_Click(object sender, EventArgs e)
        {
            check_true = true;
            Recall_Letter(1);
            label12.Text = "Question No  : 1";
        }

        private void btnq_2_Click(object sender, EventArgs e)
        {
            check_true = true;
            Recall_Letter(2);
            label12.Text = "Question No  : 2";

        }

        private void btnq_3_Click(object sender, EventArgs e)
        {
            check_true = true;
            Recall_Letter(3);
            label12.Text = "Question No  : 3";
        }

        private void btnq_4_Click(object sender, EventArgs e)
        {
            check_true = true;
            Recall_Letter(4);
            label12.Text = "Question No  : 4";
        }

        private void btnq_5_Click(object sender, EventArgs e)
        {
            check_true = true;
            Recall_Letter(5);
            label12.Text = "Question No  : 5";
        }

        private void btnq_6_Click(object sender, EventArgs e)
        {
            check_true = true;
            Recall_Letter(6);
            label12.Text = "Question No  : 6";
        }

        private void btnq_7_Click(object sender, EventArgs e)
        {
            check_true = true;
            Recall_Letter(7);
            label12.Text = "Question No  : 7";
        }

        private void btnq_8_Click(object sender, EventArgs e)
        {
            check_true = true;
            Recall_Letter(8);
            label12.Text = "Question No  : 8";
        }

        private void btnq_9_Click(object sender, EventArgs e)
        {
            check_true = true;
            Recall_Letter(9);
            label12.Text = "Question No  : 9";
        }

        private void btnq_10_Click(object sender, EventArgs e)
        {
            check_true = true;
            Recall_Letter(10);
            label12.Text = "Question No  : 10";
        }

       

        }
    }




