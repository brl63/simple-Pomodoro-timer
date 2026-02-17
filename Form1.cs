using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pomodoro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnStart.Image = null;
            btnStart.BackgroundImage = null;
        }
        public struct stTimer
        {
        public short Seconds;
        public short Minutes;
        public short Hours;
        public int TotalSecStudied;
        public bool IsItWorking;
        public bool IsBreakMood;
        public bool IsCountUp;

        }
        stTimer Timer =new stTimer();

        private bool CountDownTimer()
        {
            if (Timer.Hours == 0 && Timer.Minutes == 0 && Timer.Seconds == 0)
            {
                return true;
            }

            if (Timer.Seconds > 0)
            {
                Timer.Seconds--;
            }
            else 
            {
                if (Timer.Minutes > 0)
                {
                    Timer.Minutes--;
                    Timer.Seconds = 59;
                }
                else if (Timer.Hours > 0) 
                {
                    Timer.Hours--;
                    Timer.Minutes = 59;
                    Timer.Seconds = 59;
                }
            }

            return false; 
        }


        private void lblSec_Click(object sender, EventArgs e)
        {
            if (Timer.IsItWorking||Timer.IsCountUp) return;

            lblSec.Visible = false;
            txtSecEdit.Text = lblSec.Text;
            txtSecEdit.Visible = true;
            txtSecEdit.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (Timer.IsItWorking||Timer.IsCountUp) return;
            lblMin.Visible = false;
            txtMinEdit.Text= lblMin.Text ;
            txtMinEdit.Visible=true;
            txtMinEdit.Focus();
        }


        private void CountUp() 
        {
            Timer.Seconds++;
            if ((Timer.Seconds==60))
            {
                Timer.Minutes++;
                Timer.Seconds = 0;
            }
            if (Timer.Minutes == 60) 
            {
                Timer.Hours++;
                Timer.Minutes = 0;
                Timer.Seconds = 0;
            }
            Timer.IsItWorking = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Timer.IsCountUp)
            {
                CountUp();
                UpdateLabels();
            }
            else
            {
                
            if (CountDownTimer())
            {
                btnStart_Click(sender, new EventArgs());
                if (Timer.IsBreakMood)
                {
                    this.BackColor=Color.White;
                    Timer.IsBreakMood = false;
                }
                else
                {
                    TakeBreak();
                }
                Timer.TotalSecStudied=0;
                Console.Beep();
                MessageBox.Show("The Time Has Ended");
            }
            else
            {
                UpdateLabels();

            }
            Timer.TotalSecStudied++;
            }

        }

        private void SetInputsEnabled(bool status)
        {
            txtHoursEdit.Enabled = status;
            txtMinEdit.Enabled = status;
            txtSecEdit.Enabled = status;
        }
            private void btnStart_Click(object sender, EventArgs e)
        {
            if (Timer.IsItWorking)
            {

                SetInputsEnabled(true);
                timer1.Stop();
                Timer.IsItWorking = false;
                btnStart.BackgroundImage = Properties.Resources.play_64;
                return;
            }
            else
            {
            SetInputsEnabled(false);
            timer1.Start();
            Timer.IsItWorking = true;
            btnStart.BackgroundImage = Properties.Resources.pause_button_64; return;
            }
        }

    
        private void lblHour_Click(object sender, EventArgs e)
        {
            if (Timer.IsItWorking || Timer.IsCountUp) return;


            txtHoursEdit.Text = lblHour.Text;
            lblHour.Visible = false;
            txtHoursEdit.Visible = true;
            txtHoursEdit.Focus();
        }


        private void AllTimeTextBoxes_Leave(object sender, EventArgs e)
        {
            TextBox CurrentTextBox = (TextBox)sender;
            CurrentTextBox.Visible = false;
            short.TryParse(CurrentTextBox.Text, out short newVlue);
            if (newVlue > 59) newVlue = 59;

            if (CurrentTextBox.Name == "txtSecEdit")
            {
                lblSec.Visible = true;
                Timer.Seconds = newVlue;
                lblSec.Text = newVlue.ToString("D2");
            }
            else if (CurrentTextBox.Name == "txtMinEdit")
            {
                lblMin.Visible = true;
                Timer.Minutes = newVlue;
                lblMin.Text = newVlue.ToString("D2");
            }
            else if (CurrentTextBox.Name == "txtHoursEdit")
            {
               
                lblHour.Visible = true;
                Timer.Hours = newVlue;
                lblHour.Text = newVlue.ToString("D2");
            }
        }
        private void AllTimeTextBoxes_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                TextBox CurrentTextBox = (TextBox)sender;
                if (short.TryParse(CurrentTextBox.Text ,out short newValue))
                {
                    if (newValue > 59) newValue = 59;

                    if (CurrentTextBox.Name == "txtSecEdit")
                    {
                        
                        Timer.Seconds = newValue;
                        lblSec.Text = newValue.ToString("D2");
                        lblSec.Visible= true;
                    }
                    else if (CurrentTextBox.Name== "txtMinEdit")
                    {
                        Timer.Minutes = newValue;
                        lblMin.Text = newValue.ToString("D2");
                        lblMin.Visible= true;
                    }
                    else if(CurrentTextBox.Name== "txtHoursEdit")
                    {
                        Timer.Hours= newValue;
                        lblHour.Text = newValue.ToString("D2");
                        lblHour.Visible= true;
                    }

                    CurrentTextBox.Visible = false;

                }
            }
        }
        private void StopAndResetTimer(short Min=0)
        {
            timer1.Stop();

            Timer.Hours = 0;
            Timer.Minutes = Min;
            Timer.Seconds = 0;
            Timer.IsItWorking = false;

            lblHour.Text = "00";
            lblMin.Text = "00";
            lblSec.Text = "00";

            txtHoursEdit.Visible = false;
            txtMinEdit.Visible = false;
            txtSecEdit.Visible = false;
            SetInputsEnabled(true);

            lblHour.Visible = true;
            lblMin.Visible = true;
            lblSec.Visible = true;
            UpdateLabels();

            this.BackColor = Color.White;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
        DialogResult result=MessageBox.Show("Are You sure U wanna reset? The Timer will be 0", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                btnStart.BackgroundImage= Properties.Resources.play_64;
                StopAndResetTimer();
            }
            else
            {
                return;
            }
            

        }

        private void SetTimerTo(short min)
        {
            Timer.IsCountUp = false;
            Timer.Minutes= min;
            lblMin.Text = min.ToString("D2");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnStart.BackgroundImage = Properties.Resources.play_64_removebg_preview;
            btnReset.BackgroundImage = Properties.Resources.reset_50_removebg_preview;
        }

        private void UpdateLabels()
        {
            lblHour.Text = Timer.Hours.ToString("D2");
            lblMin.Text = Timer.Minutes.ToString("D2");
            lblSec.Text = Timer.Seconds.ToString("D2");
        }
        private void TakeBreak()
        {
            btnStart.BackgroundImage = Properties.Resources.play_64_removebg_preview;
            btnSkip.Visible = true;

            if (Timer.TotalSecStudied <= 1800)
            {
                Timer.Minutes = 5;
            }
            else
            {
                Timer.Minutes = 10;
            }
            UpdateLabels();
            this.BackColor = Color.FromArgb(163, 190, 140);
        }

        private void txtMinEdit_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            StopAndResetTimer(25);
            btnSkip.Visible = false;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        private void countUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Timer.IsCountUp= true;
            StopAndResetTimer();
        }

        private void minutesToolStripMenuItem50_Click(object sender, EventArgs e)
        {
            StopAndResetTimer();
            SetTimerTo(50);
        }

   
        private void minutesToolStripMenuItem25_Click(object sender, EventArgs e)
        {
            StopAndResetTimer();
            SetTimerTo(25);

        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopAndResetTimer();
            SetTimerTo(0);
        }
    }
}
