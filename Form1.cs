using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string text1 = "tebrikler, kazandınız!";
        string text0 = "bilgisayar kazandı!";
        public void _ButtonColor()
        {
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
        }
        public void _buttonDisabled()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }
        public void _buttonEnabled()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }
        public Form1()
        {
            InitializeComponent();
        }
        int userScore = 0;
        int pcScore = 0;



       

        private void button1_Click(object sender, EventArgs e)
        {
            _ButtonColor();
         

            Random random = new Random();
            int deger = random.Next(1, 4);
            if (deger == 1)
            {
                label3.Text = "beraberlik";
                label3.BackColor = Color.Yellow;
                button6.BackColor = Color.Orange;
            }
            else if (deger == 2)
            {
                label3.Text = "kaybettiniz";
                label3.BackColor = Color.Red;
                button5.BackColor = Color.Orange;
                pcScore++;

                label2.Text = pcScore.ToString();
                if (pcScore == 5)
                {
                    MessageBox.Show(text0);
                }



            }
            else if (deger == 3)
            {
                label3.Text = "kazandınız";
                label3.BackColor = Color.Green;
                button4.BackColor = Color.Orange;
                userScore++;

                label1.Text = userScore.ToString();
                if (userScore == 5)
                {
                    MessageBox.Show(text1);
                }
              

            }
            if (pcScore == 5 || userScore == 5)
            {
                _buttonDisabled();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _ButtonColor();
          
            Random random = new Random();
            int deger = random.Next(1, 4);
            if (deger == 1)
            {
                label3.Text = "kaybettiniz";
                label3.BackColor = Color.Red;
                button6.BackColor = Color.Orange;
                pcScore++;

                label2.Text = pcScore.ToString();
                if (pcScore == 5)
                {
                    MessageBox.Show(text0);
                }
              

            }
            else if (deger == 2)
            {
                label3.Text = "kazandınız";
                label3.BackColor = Color.Green;
                button5.BackColor = Color.Orange;
                userScore++;
                label1.Text = userScore.ToString();
                if (userScore == 5)
                {
                    MessageBox.Show(text1);
                }
              

            }
            else if (deger == 3)
            {
                label3.Text = "beraberlik";
                label3.BackColor = Color.Yellow;
                button4.BackColor = Color.Orange;
            }
            if (pcScore == 5 || userScore == 5)
            {
                _buttonDisabled();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _ButtonColor();
          
            Random random = new Random();
            int deger = random.Next(1, 4);
            if (deger == 1)
            {
                label3.Text = "kazandınız";
                label3.BackColor = Color.Green;
                button6.BackColor = Color.Orange;
                userScore++;

                label1.Text = userScore.ToString();
                if (userScore == 5)
                {
                    MessageBox.Show(text1); ;

                }
              
                

            }
            else if (deger == 2)
            {
                label3.Text = "beraberlik";
                label3.BackColor = Color.Yellow;
                button5.BackColor = Color.Orange;
            }
            else if (deger == 3)
            {
                label3.Text = "kaybettiniz";
                label3.BackColor = Color.Red;
                button4.BackColor = Color.Orange;
                pcScore++;
                label2.Text = pcScore.ToString();
                if (pcScore == 5)
                {
                    MessageBox.Show(text0);
                }
               
            }
            if (pcScore == 5 || userScore == 5)
            {
                _buttonDisabled();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            userScore = 0;
            pcScore = 0;
            label1.Text = userScore.ToString();
            label2.Text = pcScore.ToString();
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            _ButtonColor();
            label3.BackColor = Color.White;
            label3.Text = "0";
            _buttonEnabled();


        }


    }



}
