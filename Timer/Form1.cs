using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        private bool isTimerwork = false;
        bool TimerStoped = false;
    
        private int SetSeoncds= 3602;
        private int AllSeconds = 3602;
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            int hours;
            int minutes;
            int seconds;
            if (int.TryParse(textBoxHour.Text, out hours) && int.TryParse(textBoxMinute.Text, out minutes) && int.TryParse(textBoxSecond.Text, out seconds))
            {


                StopButton.Enabled = true;
                StopButton.Visible = true;

                TimerStoped = false;
                ActiveTimer.Start();
                TimerLabelShow();
                StartButton.Enabled = false;
                StartButton.Visible = false;
                NOButton.Enabled = true;

                SetSeoncds = hours * 3600 + minutes * 60 + seconds;
                AllSeconds = SetSeoncds;
                LabelHour.Text = (AllSeconds / 3600) < 10 ? "0" + (AllSeconds / 3600).ToString() : (AllSeconds / 3600).ToString();
                LabelMinute.Text = (AllSeconds % 3600 / 60) < 10 ? "0" + (AllSeconds % 3600 / 60).ToString() : (AllSeconds % 3600 / 60).ToString();
                LabelSecond.Text = (AllSeconds % 60) < 10 ? "0" + (AllSeconds % 60).ToString() : (AllSeconds % 60).ToString();
            }
            else
            {
                MessageBox.Show("не введенные данные числа");
            }



            
        }

        private void ActiveTimer_Tick(object sender, EventArgs e)
        {
            AllSeconds--;
            //(AllSeconds % 60)<10?"0"+(AllSeconds % 60).ToString():(AllSeconds % 60).ToString()

            LabelHour.Text = (AllSeconds / 3600) < 10 ? "0" + (AllSeconds / 3600).ToString() : (AllSeconds / 3600).ToString();
            LabelMinute.Text = (AllSeconds %3600/60) < 10 ? "0" + (AllSeconds % 3600 / 60).ToString() : (AllSeconds % 3600 / 60).ToString();
            LabelSecond.Text = (AllSeconds % 60) < 10 ? "0" + (AllSeconds % 60).ToString() : (AllSeconds % 60).ToString();
            if (AllSeconds == 0)
            {
                ActiveTimer.Stop();
                MessageBox.Show("время вышло");
            }
        }
        void TimerLabelShow()
        {
            LabelHour.Visible = true;
            LabelMinute.Visible = true;
            LabelSecond.Visible = true;
            label1.Visible = true;
            label2.Visible = true;

            labelhou.Visible = false;
            labelmin.Visible = false;
            labelsec.Visible = false;
            textBoxHour.Visible = false;
            textBoxHour.Enabled = false;

            textBoxMinute.Visible = false;
            textBoxMinute.Enabled = false;

            textBoxSecond.Visible = false;
            textBoxSecond.Enabled = false;
        }
        void TimerLabelHide()
        {
            LabelHour.Visible = false;
            LabelMinute.Visible = false;
            LabelSecond.Visible = false;
            label1.Visible = false;
            label2.Visible = false;

            labelhou.Visible = true;
            labelmin.Visible = true;
            labelsec.Visible = true;
            textBoxHour.Visible = true;
            textBoxHour.Enabled = true;

            textBoxMinute.Visible = true;
            textBoxMinute.Enabled = true;

            textBoxSecond.Visible = true;
            textBoxSecond.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TimerLabelHide();
            NOButton.Enabled = false;

            StopButton.Enabled = false;
            StopButton.Visible = false;


        }

        private void labelsec_Click(object sender, EventArgs e)
        {

        }

        private void NObutton_Click(object sender, EventArgs e)
        {

            StopButton.Enabled = false;
            StopButton.Visible = false;
            NOButton.Enabled = false;
            StartButton.Enabled = true;
            StartButton.Visible = true;
            StartButton.Text = "Старт";
            ActiveTimer.Stop();
            AllSeconds = 0;
            LabelHour.Text = "00";
            LabelMinute.Text = "00";
            LabelMinute.Text = "00";

            AllSeconds = SetSeoncds;

            LabelHour.Text = (AllSeconds / 3600) < 10 ? "0" + (AllSeconds / 3600).ToString() : (AllSeconds / 3600).ToString();
            LabelMinute.Text = (AllSeconds % 3600 / 60) < 10 ? "0" + (AllSeconds % 3600 / 60).ToString() : (AllSeconds % 3600 / 60).ToString();
            LabelSecond.Text = (AllSeconds % 60) < 10 ? "0" + (AllSeconds % 60).ToString() : (AllSeconds % 60).ToString();
            TimerLabelHide();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            if (TimerStoped)
            {
                StopButton.Text = "Продолжить";
                ActiveTimer.Stop();
            }
            else
            {
                ActiveTimer.Start();
                StopButton.Text = "Стоп";
            }
            TimerStoped = !TimerStoped;
        }
    }
}
