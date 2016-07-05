using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Leap;
using System.Threading;

namespace CheckMateApp
{
    public partial class WordForm : Form
    {

        DBAccess db = new DBAccess();
        int marks = 0;
        bool checkW = true;
        bool btnclick = false;
        

        public WordForm()
        {
            InitializeComponent();

            using (Controller controller = new Controller())
            {


                controller.FrameReady += newFrameHandler;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                double a1 = Convert.ToDouble(Math.Round(g1.Direction.Yaw, 2));
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
                checkletter(Thumb, Index, Middle, Ring, Pinky, a1, a2, a3, a4, a5);
            }
        }

        private void checkletter(bool Thumb, bool Index, bool Middle, bool Ring, bool Pinky, double a1, double a2, double a3, double a4, double a5)
        {
            if (label1.Text == "1")
            {
                if (label3.Text == "අ" && checkW==true)
                {
                    if (Thumb == true && Index == true && Middle == true && Ring == true && Pinky == true && a1 < -0.01 && a1 > -0.40 && a2 > -0.05 && a2 < 0.15 && a3 > -0.02 && a3 < 0.2 && a4 > -0.01 && a4 < 0.2 && a5 > -0.04 && a5 < 0.2)
                    {

                        marks++;
                        btns_1.BackColor = Color.Green;
                        checkW = false;
                        btns_2.Enabled = true;    
                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_1.BackColor = Color.Red;
                            btns_2.Enabled = true;
                        }
                    }
                }
                if (label3.Text == "ම්" && checkW == true)
                {

                    if (Thumb == false && Index == false && Middle == false && Ring == false && Pinky == false && a1 > 0.01 && a1 < 1.00 && a2 > 2.70 && a2 < 3.10 && a3 > -3.2 && a3 < -2.70 && a4 > -3.00 && a4 < -2.30 && a5 > -2.8 && a5 < -2.3)
                    {

                        marks++;
                        btns_2.BackColor = Color.Green;
                        checkW = false;
                        btns_3.Enabled = true;
                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_2.BackColor = Color.Red;
                            btns_3.Enabled = true;
                        }
                    }
                }
                if (label3.Text == " ම්" && checkW == true)
               {
                   if (Thumb == false && Index == false && Middle == false && Ring == false && Pinky == false && a1 > 0.01 && a1 < 1.00 && a2 > 2.70 && a2 < 3.10 && a3 > -3.2 && a3 < -2.70 && a4 > -3.00 && a4 < -2.30 && a5 > -2.8 && a5 < -2.3)
                   {
                       marks++;
                       btns_3.BackColor = Color.Green;
                       checkW = false;
                       btns_4.Enabled = true;
                   }
                   else
                   {
                       if (checkW == true)
                       {
                           btns_3.BackColor = Color.Red;
                           btns_4.Enabled = true;
                       }
                   }
               }
                if (label3.Text == "ආ" && checkW == true)
                {
                    if (Thumb == true && Index == false && Middle == false && Ring == false && Pinky == false && a1 > -2 && a1 < -0.05 && a2 > -2.00 && a2 < -1.00 && a3 > -2.00 && a3 < -1.00 && a4 > -2.00 && a4 < -1.00 && a5 > -2.00 && a5 < -1.00)
                    {
                        marks++;
                        btns_4.BackColor = Color.Green;
                        checkW = false;
                        lblshow.Text="Question has been finished";       
                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_4.BackColor = Color.Red;
                            lblshow.Text = "Question has been finished";
                        }
                    }

                }

            }
            if(label1.Text=="2")
            {
                if (label3.Text == "අ" && checkW == true)
                {
                    if (Thumb == true && Index == true && Middle == true && Ring == true && Pinky == true && a1 < -0.01 && a1 > -0.40 && a2 > -0.05 && a2 < 0.15 && a3 > -0.02 && a3 < 0.2 && a4 > -0.01 && a4 < 0.2 && a5 > -0.04 && a5 < 0.2)
                    {

                        marks++;
                        btns_1.BackColor = Color.Green;
                        checkW = false;
                        btns_2.Enabled = true;
                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_1.BackColor = Color.Red;
                            btns_2.Enabled = true;
                        }
                    }
                }
                if (label3.Text == "ක්" && checkW==true)
                {
                    if (Thumb == false && Index == true && Middle == true && Ring == false && Pinky == false && a1 > -0.01 && a1 < 2 && a2 > -0.02 && a2 < 1 && a3 > -0.02 && a3 < 1 && a4 > -3 && a4 < 3 && a5 > -3 && a5 < 3.2)
                    {
                        marks++;
                        btns_2.BackColor = Color.Green;
                        checkW = false;
                        btns_3.Enabled = true;
                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_2.BackColor = Color.Red;
                            btns_3.Enabled = true;
                           
                        }
                    }
                    
                }
                if (label3.Text == " ක්" && checkW == true)
                {
                    if (Thumb == false && Index == true && Middle == true && Ring == false && Pinky == false && a1 > -0.01 && a1 < 2 && a2 > -0.02 && a2 < 1 && a3 > -0.02 && a3 < 1 && a4 > -3 && a4 < 3 && a5 > -3 && a5 < 3.2)
                    {
                        marks++;
                        btns_3.BackColor = Color.Green;
                        checkW = false;
                        btns_4.Enabled = true;
                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_3.BackColor = Color.Red;
                            btns_4.Enabled = true;

                        }
                    }

                }
                if (label3.Text == "ආ" && checkW == true)
                {
                    if (Thumb == true && Index == false && Middle == false && Ring == false && Pinky == false && a1 > -2 && a1 < -0.05 && a2 > -2.00 && a2 < -1.00 && a3 > -2.00 && a3 < -1.00 && a4 > -2.00 && a4 < -1.00 && a5 > -2.00 && a5 < -1.00)
                    {
                        marks++;
                        btns_4.BackColor = Color.Green;
                        checkW = false;
                        lblshow.Text = "Question has been finished";
                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_4.BackColor = Color.Red;
                            lblshow.Text = "Question has been finished";
                        }
                    }

                }
            }
            if (label1.Text == "3")
            {
                if (label3.Text == "ක්" && checkW == true)
                {
                    if (Thumb == false && Index == true && Middle == true && Ring == false && Pinky == false && a1 > -0.01 && a1 < 2 && a2 > -0.02 && a2 < 1 && a3 > -0.02 && a3 < 1 && a4 > -3 && a4 < 3 && a5 > -3 && a5 < 3.2)
                    {
                        marks++;
                        btns_1.BackColor = Color.Green;
                        checkW = false;
                        btns_2.Enabled = true;
                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_1.BackColor = Color.Red;
                            btns_2.Enabled = true;

                        }
                    }

                }
                if (label3.Text == "අ" && checkW == true)
                {
                    if (Thumb == true && Index == true && Middle == true && Ring == true && Pinky == true && a1 < -0.01 && a1 > -0.40 && a2 > -0.05 && a2 < 0.15 && a3 > -0.02 && a3 < 0.2 && a4 > -0.01 && a4 < 0.2 && a5 > -0.04 && a5 < 0.2)
                    {

                        marks++;
                        btns_2.BackColor = Color.Green;
                        checkW = false;
                        btns_3.Enabled = true;
                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_2.BackColor = Color.Red;
                            btns_3.Enabled = true;
                        }
                    }
                }
                if (label3.Text == "ම්" && checkW == true)
                {

                    if (Thumb == false && Index == false && Middle == false && Ring == false && Pinky == false && a1 > 0.01 && a1 < 1.00 && a2 > 2.70 && a2 < 3.10 && a3 > -3.2 && a3 < -2.70 && a4 > -3.00 && a4 < -2.30 && a5 > -2.8 && a5 < -2.3)
                    {

                        marks++;
                        btns_3.BackColor = Color.Green;
                        checkW = false;
                        btns_4.Enabled = true;
                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_3.BackColor = Color.Red;
                            btns_4.Enabled = true;
                        }
                    }
                }
                if (label3.Text == " අ" && checkW == true)
                {
                    if (Thumb == true && Index == true && Middle == true && Ring == true && Pinky == true && a1 < -0.01 && a1 > -0.40 && a2 > -0.05 && a2 < 0.15 && a3 > -0.02 && a3 < 0.2 && a4 > -0.01 && a4 < 0.2 && a5 > -0.04 && a5 < 0.2)
                    {

                        marks++;
                        btns_4.BackColor = Color.Green;
                        checkW = false;
                        btns_5.Enabled = true;
                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_4.BackColor = Color.Red;
                            btns_5.Enabled = true;
                        }
                    }
                }
                if (label3.Text == "ල්" && checkW == true)
                {
                    if (Thumb == true && Index == true && Middle == false && Ring == false && Pinky == false && a1 > -1.5 && a1 < -0.4 && a2 > -0.01 && a2 < 1.00 && a3 > -3.2 && a3 < 3.1 && a4 > -3.2 && a4 < 3.1 && a5 > -3.2 && a5 < 3.2)
                    {
                        marks++;
                        btns_5.BackColor = Color.Green;
                        checkW = false;
                        lblshow.Text = "Question has been finished";
                        

                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_5.BackColor = Color.Red;
                            lblshow.Text = "Question has been finished";
                        }
                    }
                }
            }
            if (label1.Text == "4")
            {
                if (label3.Text == "අ" && checkW == true)
                {
                    if (Thumb == true && Index == true && Middle == true && Ring == true && Pinky == true && a1 < -0.01 && a1 > -0.40 && a2 > -0.05 && a2 < 0.15 && a3 > -0.02 && a3 < 0.2 && a4 > -0.01 && a4 < 0.2 && a5 > -0.04 && a5 < 0.2)
                    {

                        marks++;
                        btns_1.BackColor = Color.Green;
                        checkW = false;
                        btns_2.Enabled = true;
                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_1.BackColor = Color.Red;
                            btns_2.Enabled = true;
                        }
                    }
                }
                if (label3.Text == "ද්" && checkW == true)
                {
                    if (Thumb == false && Index == true && Middle == false && Ring == false && Pinky == false && a1 > 0.01 && a1 < 1.00 && a2 > 0.02 && a2 < 1 && a3 > -3.2 && a3 < -2.70 && a4 > -3.00 && a4 < -2.30 && a5 > -2.8 && a5 < -2.3)
                     {
                         marks++;
                         btns_2.BackColor = Color.Green;
                         checkW = false;
                         btns_3.Enabled = true;
                     }
                     else
                     {
                         if (checkW == true)
                         {
                             btns_2.BackColor = Color.Red;
                             btns_3.Enabled = true;
                         }
                     }
                }
                if (label3.Text == " අ" && checkW == true)
                {
                    if (Thumb == true && Index == true && Middle == true && Ring == true && Pinky == true && a1 < -0.01 && a1 > -0.40 && a2 > -0.05 && a2 < 0.15 && a3 > -0.02 && a3 < 0.2 && a4 > -0.01 && a4 < 0.2 && a5 > -0.04 && a5 < 0.2)
                    {

                        marks++;
                        btns_3.BackColor = Color.Green;
                        checkW = false;
                        lblshow.Text = "Question has been finished";
                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_3.BackColor = Color.Red;
                            lblshow.Text = "Question has been finished";
                            
                        }
                    }
                }
            }
            if (label1.Text == "5")
            {
                if (label3.Text == "අ" && checkW == true)
                {
                    if (Thumb == true && Index == true && Middle == true && Ring == true && Pinky == true && a1 < -0.01 && a1 > -0.40 && a2 > -0.05 && a2 < 0.15 && a3 > -0.02 && a3 < 0.2 && a4 > -0.01 && a4 < 0.2 && a5 > -0.04 && a5 < 0.2)
                    {

                        marks++;
                        btns_1.BackColor = Color.Green;
                        checkW = false;
                        btns_2.Enabled = true;
                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_1.BackColor = Color.Red;
                            btns_2.Enabled = true;
                        }
                    }
                }
                if (label3.Text == "ම්" && checkW == true)
                {

                    if (Thumb == false && Index == false && Middle == false && Ring == false && Pinky == false && a1 > 0.01 && a1 < 1.00 && a2 > 2.70 && a2 < 3.10 && a3 > -3.2 && a3 < -2.70 && a4 > -3.00 && a4 < -2.30 && a5 > -2.8 && a5 < -2.3)
                    {

                        marks++;
                        btns_2.BackColor = Color.Green;
                        checkW = false;
                        btns_3.Enabled = true;
                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_2.BackColor = Color.Red;
                            btns_3.Enabled = true;
                        }
                    }
                }
                if (label3.Text == " අ" && checkW == true)
                {
                    if (Thumb == true && Index == true && Middle == true && Ring == true && Pinky == true && a1 < -0.01 && a1 > -0.40 && a2 > -0.05 && a2 < 0.15 && a3 > -0.02 && a3 < 0.2 && a4 > -0.01 && a4 < 0.2 && a5 > -0.04 && a5 < 0.2)
                    {

                        marks++;
                        btns_3.BackColor = Color.Green;
                        checkW = false;
                        btns_4.Enabled = true;
                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_3.BackColor = Color.Red;
                            btns_4.Enabled = true;
                        }
                    }
                }
                if (label3.Text == "ල්" && checkW == true)
                {
                    if (Thumb == true && Index == true && Middle == false && Ring == false && Pinky == false && a1 > -1.5 && a1 < -0.4 && a2 > -0.01 && a2 < 1.00 && a3 > -3.2 && a3 < 3.1 && a4 > -3.2 && a4 < 3.1 && a5 > -3.2 && a5 < 3.2)
                    {
                        marks++;
                        btns_4.BackColor = Color.Green;
                        checkW = false;
                        lblshow.Text = "Question has been finished";


                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_4.BackColor = Color.Red;
                            lblshow.Text = "Question has been finished";
                        }
                    }
                }
            }
            if (label1.Text == "6")
            {
                if (label3.Text == "ම්" && checkW == true)
                {

                    if (Thumb == false && Index == false && Middle == false && Ring == false && Pinky == false && a1 > 0.01 && a1 < 1.00 && a2 > 2.70 && a2 < 3.10 && a3 > -3.2 && a3 < -2.70 && a4 > -3.00 && a4 < -2.30 && a5 > -2.8 && a5 < -2.3)
                    {

                        marks++;
                        btns_1.BackColor = Color.Green;
                        checkW = false;
                        btns_2.Enabled = true;
                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_1.BackColor = Color.Red;
                            btns_2.Enabled = true;
                        }
                    }
                }
                if (label3.Text == "අ" && checkW == true)
                {
                    if (Thumb == true && Index == true && Middle == true && Ring == true && Pinky == true && a1 < -0.01 && a1 > -0.40 && a2 > -0.05 && a2 < 0.15 && a3 > -0.02 && a3 < 0.2 && a4 > -0.01 && a4 < 0.2 && a5 > -0.04 && a5 < 0.2)
                    {

                        marks++;
                        btns_2.BackColor = Color.Green;
                        checkW = false;
                        btns_3.Enabled = true;
                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_2.BackColor = Color.Red;
                            btns_3.Enabled = true;
                        }
                    }
                }
                if (label3.Text == "ල්" && checkW == true)
                {
                    if (Thumb == true && Index == true && Middle == false && Ring == false && Pinky == false && a1 > -1.5 && a1 < -0.4 && a2 > -0.01 && a2 < 1.00 && a3 > -3.2 && a3 < 3.1 && a4 > -3.2 && a4 < 3.1 && a5 > -3.2 && a5 < 3.2)
                    {
                        marks++;
                        btns_3.BackColor = Color.Green;
                        checkW = false;
                        btns_4.Enabled = true;


                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_3.BackColor = Color.Red;
                            btns_4.Enabled = true;
                        }
                    }
                }
                if (label3.Text == " අ" && checkW == true)
                {

                    if (Thumb == true && Index == true && Middle == true && Ring == true && Pinky == true && a1 < -0.01 && a1 > -0.40 && a2 > -0.05 && a2 < 0.15 && a3 > -0.02 && a3 < 0.2 && a4 > -0.01 && a4 < 0.2 && a5 > -0.04 && a5 < 0.2)
                    {

                        marks++;
                        btns_4.BackColor = Color.Green;
                        checkW = false;
                        lblshow.Text = "Question has been finished";
                        
                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_4.BackColor = Color.Red;
                            lblshow.Text = "Question has been finished";
                        }
                    }
                }
            }
            if (label1.Text == "7")
            {
                if (label3.Text == "ග්" && checkW == true)
                {
                    if (Thumb == true && Index == true && Middle == false && Ring == false && Pinky == false && a1 > -1.5 && a1 < -0.4 && a2 > -0.01 && a2 < 1.00 && a3 > -3.2 && a3 < 3.1 && a4 > -3.2 && a4 < 3.1 && a5 > -3.2 && a5 < 3.2)
                    {
                        marks++;
                        btns_1.BackColor = Color.Green;
                        checkW = false;
                        btns_2.Enabled = true;

                    }
                    else
                    {
                        if (checkW == true)
                        {

                            btns_1.BackColor = Color.Red;
                            btns_2.Enabled = true;
                        }
                    }
                }
                if (label3.Text == "අ" && checkW == true)
                {
                    if (Thumb == true && Index == true && Middle == true && Ring == true && Pinky == true && a1 < -0.01 && a1 > -0.40 && a2 > -0.05 && a2 < 0.15 && a3 > -0.02 && a3 < 0.2 && a4 > -0.01 && a4 < 0.2 && a5 > -0.04 && a5 < 0.2)
                    {

                        marks++;
                        btns_2.BackColor = Color.Green;
                        checkW = false;
                        btns_3.Enabled = true;
                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_2.BackColor = Color.Red;
                            btns_3.Enabled = true;
                        }
                    }
                }
                if (label3.Text == "ව්" && checkW == true)
                {
                    if (Thumb == false && Index == true && Middle == true && Ring == true && Pinky == false)
                    {

                        marks++;
                        btns_3.BackColor = Color.Green;
                        checkW = false;
                        btns_4.Enabled = true;
                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_3.BackColor = Color.Red;
                            btns_4.Enabled = true;
                        }
                    }
                }
                if (label3.Text == " අ" && checkW == true)
                {
                    if (Thumb == true && Index == true && Middle == true && Ring == true && Pinky == true && a1 < -0.01 && a1 > -0.40 && a2 > -0.05 && a2 < 0.15 && a3 > -0.02 && a3 < 0.2 && a4 > -0.01 && a4 < 0.2 && a5 > -0.04 && a5 < 0.2)
                    {

                        marks++;
                        btns_4.BackColor = Color.Green;
                        checkW = false;
                        btns_5.Enabled = true;
                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_4.BackColor = Color.Red;
                            btns_5.Enabled = true;
                        }
                    }
                }
                if (label3.Text == "ය්" && checkW == true)
                {
                    if (Thumb == true && Index == false && Middle == false && Ring == false && Pinky == true && a1 > -0.80 && a1 < 1 && a2 > -2.80 && a2 < 3.2 && a3 > -3.1 && a3 < -2.00 && a4 > -3.1 && a4 < -2.5 && a5 > -0.01 && a5 < 2)
                    {

                        marks++;
                        btns_5.BackColor = Color.Green;
                        checkW = false;
                        btns_6.Enabled = true;
                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_5.BackColor = Color.Red;
                            btns_6.Enabled = true;
                        }
                    }
                }
                if (label3.Text == "ආ" && checkW == true)
                {
                    if (Thumb == true && Index == false && Middle == false && Ring == false && Pinky == false && a1 > -2 && a1 < -0.05 && a2 > -2.00 && a2 < -1.00 && a3 > -2.00 && a3 < -1.00 && a4 > -2.00 && a4 < -1.00 && a5 > -2.00 && a5 < -1.00)
                    {
                        marks++;
                        btns_6.BackColor = Color.Green;
                        checkW = false;
                        lblshow.Text = "Question has been finished";
                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_6.BackColor = Color.Red;
                            lblshow.Text = "Question has been finished";
                        }
                    }

                }
            }
            if (label1.Text == "8")
            {
                if (label3.Text == "අ" && checkW == true)
                {
                    if (Thumb == true && Index == true && Middle == true && Ring == true && Pinky == true && a1 < -0.01 && a1 > -0.40 && a2 > -0.05 && a2 < 0.15 && a3 > -0.02 && a3 < 0.2 && a4 > -0.01 && a4 < 0.2 && a5 > -0.04 && a5 < 0.2)
                    {

                        marks++;
                        btns_1.BackColor = Color.Green;
                        checkW = false;
                        btns_2.Enabled = true;
                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_1.BackColor = Color.Red;
                            btns_2.Enabled = true;
                        }
                    }
                }
                if (label3.Text == "ව්" && checkW == true)
                {
                    if (Thumb == false && Index == true && Middle == true && Ring == true && Pinky == false)
                    {

                        marks++;
                        btns_2.BackColor = Color.Green;
                        checkW = false;
                        btns_3.Enabled = true;
                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_2.BackColor = Color.Red;
                            btns_3.Enabled = true;
                        }
                    }
                }
                if (label3.Text == " ව්" && checkW == true)
                {
                    if (Thumb == false && Index == true && Middle == true && Ring == true && Pinky == false)
                    {

                        marks++;
                        btns_3.BackColor = Color.Green;
                        checkW = false;
                        btns_4.Enabled = true;
                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_3.BackColor = Color.Red;
                            btns_4.Enabled = true;
                        }
                    }
                }
                if (label3.Text == " අ" && checkW == true)
                {
                    if (Thumb == true && Index == true && Middle == true && Ring == true && Pinky == true && a1 < -0.01 && a1 > -0.40 && a2 > -0.05 && a2 < 0.15 && a3 > -0.02 && a3 < 0.2 && a4 > -0.01 && a4 < 0.2 && a5 > -0.04 && a5 < 0.2)
                    {

                        marks++;
                        btns_4.BackColor = Color.Green;
                        checkW = false;
                        lblshow.Text = "Question has been finished";
                        
                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_4.BackColor = Color.Red;
                            lblshow.Text = "Question has been finished";
                           
                        }
                    }
                }
            }
            if (label1.Text == "9")
            {
                if (label3.Text == "ය්" && checkW == true)
                {
                    if (Thumb == true && Index == false && Middle == false && Ring == false && Pinky == true && a1 > -0.80 && a1 < 1 && a2 > -2.80 && a2 < 3.2 && a3 > -3.1 && a3 < -2.00 && a4 > -3.1 && a4 < -2.5 && a5 > -0.01 && a5 < 2)
                    {

                        marks++;
                        btns_1.BackColor = Color.Green;
                        checkW = false;
                        btns_2.Enabled = true;
                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_1.BackColor = Color.Red;
                            btns_2.Enabled = true;
                        }
                    }
                }
                if (label3.Text == "අ" && checkW == true)
                {
                    if (Thumb == true && Index == true && Middle == true && Ring == true && Pinky == true && a1 < -0.01 && a1 > -0.40 && a2 > -0.05 && a2 < 0.15 && a3 > -0.02 && a3 < 0.2 && a4 > -0.01 && a4 < 0.2 && a5 > -0.04 && a5 < 0.2)
                    {

                        marks++;
                        btns_2.BackColor = Color.Green;
                        checkW = false;
                        btns_3.Enabled = true;
                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_2.BackColor = Color.Red;
                            btns_3.Enabled = true;
                        }
                    }
                }
                if (label3.Text == "ක්" && checkW == true)
                {
                    if (Thumb == false && Index == true && Middle == true && Ring == false && Pinky == false && a1 > -0.01 && a1 < 2 && a2 > -0.02 && a2 < 1 && a3 > -0.02 && a3 < 1 && a4 > -3 && a4 < 3 && a5 > -3 && a5 < 3.2)
                    {
                        marks++;
                        btns_3.BackColor = Color.Green;
                        checkW = false;
                        btns_4.Enabled = true;
                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_3.BackColor = Color.Red;
                            btns_4.Enabled = true;

                        }
                    }

                }
                if (label3.Text == " ක්" && checkW == true)
                {
                    if (Thumb == false && Index == true && Middle == true && Ring == false && Pinky == false && a1 > -0.01 && a1 < 2 && a2 > -0.02 && a2 < 1 && a3 > -0.02 && a3 < 1 && a4 > -3 && a4 < 3 && a5 > -3 && a5 < 3.2)
                    {
                        marks++;
                        btns_4.BackColor = Color.Green;
                        checkW = false;
                        btns_5.Enabled = true;
                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_4.BackColor = Color.Red;
                            btns_5.Enabled = true;

                        }
                    }

                }
                if (label3.Text == " අ" && checkW == true)
                {
                    if (Thumb == true && Index == true && Middle == true && Ring == true && Pinky == true && a1 < -0.01 && a1 > -0.40 && a2 > -0.05 && a2 < 0.15 && a3 > -0.02 && a3 < 0.2 && a4 > -0.01 && a4 < 0.2 && a5 > -0.04 && a5 < 0.2)
                    {

                        marks++;
                        btns_5.BackColor = Color.Green;
                        checkW = false;
                        btns_6.Enabled = true;
                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_5.BackColor = Color.Red;
                            btns_6.Enabled = true;
                        }
                    }
                }
                if (label3.Text == "ල්" && checkW == true)
                {
                    if (Thumb == true && Index == true && Middle == false && Ring == false && Pinky == false && a1 > -1.5 && a1 < -0.4 && a2 > -0.01 && a2 < 1.00 && a3 > -3.2 && a3 < 3.1 && a4 > -3.2 && a4 < 3.1 && a5 > -3.2 && a5 < 3.2)
                    {
                        marks++;
                        btns_6.BackColor = Color.Green;
                        checkW = false;
                        btns_7.Enabled = true;


                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_6.BackColor = Color.Red;
                            btns_7.Enabled = true;
                        }
                    }
                }
                if (label3.Text == "  අ" && checkW == true)
                {
                    if (Thumb == true && Index == true && Middle == true && Ring == true && Pinky == true && a1 < -0.01 && a1 > -0.40 && a2 > -0.05 && a2 < 0.15 && a3 > -0.02 && a3 < 0.2 && a4 > -0.01 && a4 < 0.2 && a5 > -0.04 && a5 < 0.2)
                    {

                        marks++;
                        btns_7.BackColor = Color.Green;
                        checkW = false;
                        lblshow.Text = "Question has been finished";
                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_7.BackColor = Color.Red;
                            lblshow.Text = "Question has been finished";
                        }
                    }
                }
            }
            if (label1.Text == "10")
            {
                if (label3.Text == "බ්" && checkW == true)
                {
                    if (Thumb == false && Index == true && Middle == true && Ring == true && Pinky == true && a2 > -0.05 && a2 < 0.15 && a3 > -0.02 && a3 < 0.2 && a4 > -0.01 && a4 < 0.2 && a5 > -0.04 && a5 < 0.2)
                    {
                        marks++;
                        btns_1.BackColor = Color.Green;
                        checkW = false;
                        btns_2.Enabled = true;


                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_1.BackColor = Color.Red;
                            btns_2.Enabled = true;
                        }
                    }
                }
                if (label3.Text == "අ" && checkW == true)
                {
                    if (Thumb == true && Index == true && Middle == true && Ring == true && Pinky == true && a1 < -0.01 && a1 > -0.40 && a2 > -0.05 && a2 < 0.15 && a3 > -0.02 && a3 < 0.2 && a4 > -0.01 && a4 < 0.2 && a5 > -0.04 && a5 < 0.2)
                    {

                        marks++;
                        btns_2.BackColor = Color.Green;
                        checkW = false;
                        btns_3.Enabled = true;
                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_2.BackColor = Color.Red;
                            btns_3.Enabled = true;
                        }
                    }
                }
                if (label3.Text == "ල්" && checkW == true)
                {
                    if (Thumb == true && Index == true && Middle == false && Ring == false && Pinky == false && a1 > -1.5 && a1 < -0.4 && a2 > -0.01 && a2 < 1.00 && a3 > -3.2 && a3 < 3.1 && a4 > -3.2 && a4 < 3.1 && a5 > -3.2 && a5 < 3.2)
                    {
                        marks++;
                        btns_3.BackColor = Color.Green;
                        checkW = false;
                        btns_4.Enabled = true;


                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_3.BackColor = Color.Red;
                            btns_4.Enabled = true;
                        }
                    }
                }
                if (label3.Text == " අ" && checkW == true)
                {
                    if (Thumb == true && Index == true && Middle == true && Ring == true && Pinky == true && a1 < -0.01 && a1 > -0.40 && a2 > -0.05 && a2 < 0.15 && a3 > -0.02 && a3 < 0.2 && a4 > -0.01 && a4 < 0.2 && a5 > -0.04 && a5 < 0.2)
                    {

                        marks++;
                        btns_4.BackColor = Color.Green;
                        checkW = false;
                        btns_5.Enabled = true;
                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_4.BackColor = Color.Red;
                            btns_5.Enabled = true;
                        }
                    }
                }
                if (label3.Text == " ල්" && checkW == true)
                {
                    if (Thumb == true && Index == true && Middle == false && Ring == false && Pinky == false && a1 > -1.5 && a1 < -0.4 && a2 > -0.01 && a2 < 1.00 && a3 > -3.2 && a3 < 3.1 && a4 > -3.2 && a4 < 3.1 && a5 > -3.2 && a5 < 3.2)
                    {
                        marks++;
                        btns_5.BackColor = Color.Green;
                        checkW = false;
                        btns_6.Enabled = true;


                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_5.BackColor = Color.Red;
                            btns_6.Enabled = true;
                        }
                    }
                }
                if (label3.Text == "ආ" && checkW == true)
                {
                    if (Thumb == true && Index == false && Middle == false && Ring == false && Pinky == false && a1 > -2 && a1 < -0.05 && a2 > -2.00 && a2 < -1.00 && a3 > -2.00 && a3 < -1.00 && a4 > -2.00 && a4 < -1.00 && a5 > -2.00 && a5 < -1.00)
                    {
                        marks++;
                        btns_6.BackColor = Color.Green;
                        checkW = false;
                        lblshow.Text = "Question has been finished";
                    }
                    else
                    {
                        if (checkW == true)
                        {
                            btns_6.BackColor = Color.Red;
                            lblshow.Text = "Question has been finished";
                        }
                    }

                }
            }


        }
                   



  
        private void letterQuizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LetterForm letter = new LetterForm();
            this.Hide();
            letter.Show();
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
            FormMainPage mainform = new FormMainPage();
            this.Hide();
            mainform.Show();

        }
        public int Recall_Letter(int qNo)
        {
            DataSet ds = db.FindWord(Convert.ToInt16(qNo));
            if (ds.Tables[0].Rows.Count > 0)
            {
                label1.Text = ds.Tables[0].Rows[0][0].ToString();
                label2.Text = ds.Tables[0].Rows[0][1].ToString();
               // label3.Text = ds.Tables[0].Rows[0][2].ToString();
               
            }
            return -1;
        }

        private void btnq_1_Click(object sender, EventArgs e)
        {
            if (marks == 4)
            {
                btnq_1.BackColor = Color.Green;
                btnq_1.Enabled = false;
                btnq_2.Enabled = true;
                marks = 0;
            }

            Recall_Letter(1);
            btns_1.Text = "අ";
            btns_2.Text = "ම්";
            btns_3.Text = " ම්";
            btns_4.Text = "ආ";
            btns_1.Enabled = true;
            btns_2.Enabled = false;
            btns_3.Enabled = false;
            btns_4.Enabled = false;
            btns_1.Visible = true;
            btns_2.Visible = true;
            btns_3.Visible = true;
            btns_4.Visible = true;
            btns_5.Visible = false;
            btns_6.Visible = false;
            btns_7.Visible = false;
         

            

            
        }

  
        private void WordForm_Load(object sender, EventArgs e)
        {
            btnq_1.PerformClick();
   
         

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            marks++;
            checkW = true;
            label3.Text =btns_1.Text;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            marks++;
            checkW = true;
            label3.Text = btns_2.Text;
            btns_1.Enabled = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            marks++;
           checkW = true;
           btnclick = true;
           label3.Text = btns_3.Text;
           btns_2.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            marks++;
            checkW = true;
            label3.Text = btns_4.Text;
            btns_3.Enabled = false;
           
        }

        private void btnq_2_Click(object sender, EventArgs e)
        {

            lblshow.Text = "";
            btnColorChange();
            btns_1.Enabled = true;
            btns_2.Enabled = false;
            btns_3.Enabled = false;
            btns_4.Enabled = false;
            Recall_Letter(2);
            btns_1.Text = "අ";
            btns_2.Text = "ක්";
            btns_3.Text = " ක්";
            btns_4.Text = "ආ";
            btns_1.Visible = true;
            btns_2.Visible = true;
            btns_3.Visible = true;
            btns_4.Visible = true;
            btns_5.Visible = false;
            btns_6.Visible = false;
            btns_7.Visible = false;
         
          
            
        }
        public void btnColorChange()
        {
            btns_1.BackColor = Color.WhiteSmoke;
            btns_2.BackColor = Color.WhiteSmoke;
            btns_3.BackColor = Color.WhiteSmoke;
            btns_4.BackColor = Color.WhiteSmoke;
        }

        private void btnq_3_Click(object sender, EventArgs e)
        {
           

            btns_5.Visible = true;
            btns_2.Enabled = false;
            btns_3.Enabled = false;
            btns_4.Enabled = false;
            btns_5.Enabled = false;
            Recall_Letter(3);
            btns_1.Text = "ක්";
            btns_2.Text = "අ";
            btns_3.Text = "ම්";
            btns_4.Text =" අ";
            btns_5.Text = "ල්";
            btns_1.Visible = true;
            btns_2.Visible = true;
            btns_3.Visible = true;
            btns_4.Visible = true;
            btns_5.Visible = true;
            btns_6.Visible = false;
            btns_7.Visible = false;
         
        }

        private void btns_5_Click(object sender, EventArgs e)
        {
            checkW = true;
            label3.Text = btns_5.Text;
            btns_4.Enabled = false;
        }

        private void btnq_4_Click(object sender, EventArgs e)
        {
           
            Recall_Letter(4);
            btns_1.Text = "අ";
            btns_2.Text = "ද්";
            btns_3.Text =" අ";
            btns_1.Visible = true;
            btns_2.Visible = true;
            btns_3.Visible = true;
            btns_4.Visible = false;
            btns_5.Visible = false;
            btns_6.Visible = false;
            btns_7.Visible = false;
         
        }

        private void btnq_5_Click(object sender, EventArgs e)
        {
          
            Recall_Letter(5);
            btns_1.Visible = true;
            btns_2.Visible = true;
            btns_3.Visible = true;
            btns_4.Visible = true;
            btns_5.Visible = false;
            btns_6.Visible = false;
            btns_7.Visible = false;
         
             btns_1.Text = "අ";
            btns_2.Text = "ම්";
            btns_3.Text =" අ";
            btns_4.Text ="ල්";
        }

        private void btnq_6_Click(object sender, EventArgs e)
        {
            Recall_Letter(6);
            btns_1.Visible = true;
            btns_2.Visible = true;
            btns_3.Visible = true;
            btns_4.Visible = true;
            btns_5.Visible = false;
            btns_6.Visible = false;
            btns_7.Visible = false;
            btns_1.Text = "ම්";
            btns_2.Text = "අ";
            btns_3.Text = "ල්";
            btns_4.Text = " අ";
        }

        private void btnq_7_Click(object sender, EventArgs e)
        {
            Recall_Letter(7);
            btns_1.Visible = true;
            btns_2.Visible = true;
            btns_3.Visible = true;
            btns_4.Visible = true;
            btns_5.Visible = true;
            btns_6.Visible = true;
            btns_7.Visible = false;
         
            btns_1.Enabled = true;
            btns_2.Enabled = false;
            btns_3.Enabled = false;
            btns_4.Enabled = false;
            btns_5.Enabled = false;
            btns_6.Enabled = false;
            btns_1.Text = "ග්";
            btns_2.Text = "අ";
            btns_3.Text = "ව්";
            btns_4.Text = " අ";
            btns_5.Text = "ය්";
            btns_6.Text = "ආ";
        }

        private void btns_6_Click(object sender, EventArgs e)
        {
            checkW = true;
            label3.Text = btns_6.Text;
            btns_5.Enabled = false;
        }

        private void btnq_8_Click(object sender, EventArgs e)
        {
            Recall_Letter(8);
            btns_1.Visible = true;
            btns_2.Visible = true;
            btns_3.Visible = true;
            btns_4.Visible = true;
            btns_5.Visible = false;
            btns_6.Visible = false;
            btns_7.Visible = false;
            btns_1.Text = "අ";
            btns_2.Text = "ව්";
            btns_3.Text = " ව්";
            btns_4.Text = " අ";
        }

        private void btnq_9_Click(object sender, EventArgs e)
        {
            Recall_Letter(9);
            btns_1.Visible = true;
            btns_2.Visible = true;
            btns_3.Visible = true;
            btns_4.Visible = true;
            btns_5.Visible = true;
            btns_6.Visible = true;
            btns_7.Visible = true;
            btns_1.Enabled = true;
            btns_2.Enabled = false;
            btns_3.Enabled = false;
            btns_4.Enabled = false;
            btns_5.Enabled = false;
            btns_6.Enabled = false;
            btns_7.Enabled = false;
            btns_1.Text = "ය්";
            btns_2.Text = "අ";
            btns_3.Text = "ක්";
            btns_4.Text = " ක්";
            btns_5.Text = " අ";
            btns_6.Text = "ල්";
            btns_7.Text = "  අ";
        }

        private void btns_7_Click(object sender, EventArgs e)
        {
            checkW = true;
            label3.Text = btns_7.Text;
            btns_6.Enabled = false;
        }

        private void btnq_10_Click(object sender, EventArgs e)
        {
            Recall_Letter(10);
            btns_1.Visible = true;
            btns_2.Visible = true;
            btns_3.Visible = true;
            btns_4.Visible = true;
            btns_5.Visible = true;
            btns_6.Visible = true;
            btns_7.Visible = false;
            btns_1.Enabled = true;
            btns_2.Enabled = false;
            btns_3.Enabled = false;
            btns_4.Enabled = false;
            btns_5.Enabled = false;
            btns_6.Enabled = false;
            btns_1.Text = "බ්";
            btns_2.Text = "අ";
            btns_3.Text = "ල්";
            btns_4.Text = " අ";
            btns_5.Text = " ල්";
            btns_6.Text = "ආ";
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Login logout = new Form_Login();
            this.Hide();
            logout.Show();
        }
    }
}

