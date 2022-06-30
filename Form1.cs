using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        int userScore = 0;
        int pcScore = 0;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            Random random = new Random();
            int deger = random.Next(1, 4);
            if (deger == 1)
            {
                label3.Text = "beraberlik";
                label3.BackColor = Color.Yellow;
                button6.BackColor = Color.Orange;
                userScore++;
                label1.Text = userScore.ToString();
                pcScore++;
                label2.Text = pcScore.ToString();



            }
            else if (deger == 2)
            {
                label3.Text = "kaybettiniz";
                label3.BackColor = Color.Red;
                button5.BackColor = Color.Orange;
                pcScore++;
                label2.Text = pcScore.ToString();
            }
            else if (deger == 3)
            {
                label3.Text = "kazandınız";
                label3.BackColor = Color.Green;
                button4.BackColor = Color.Orange;
                userScore++;
                label1.Text = userScore.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            Random random = new Random();
            int deger = random.Next(1, 4);
            if (deger == 1)
            {
                label3.Text = "kaybettiniz";
                label3.BackColor = Color.Red;
                button6.BackColor = Color.Orange;
                pcScore++;
                label2.Text = pcScore.ToString();

            }
            else if (deger == 2)
            {
                label3.Text = "kazandınız";
                label3.BackColor = Color.Green;
                button5.BackColor = Color.Orange;
                userScore++;
                label1.Text = userScore.ToString();
            }
            else if (deger == 3)
            {
                label3.Text = "beraberlik";
                label3.BackColor = Color.Yellow;
                button4.BackColor = Color.Orange;
                pcScore++;
                label2.Text = pcScore.ToString();
                userScore++;
                label1.Text = userScore.ToString();
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            Random random = new Random();
            int deger = random.Next(1, 4);
            if (deger == 1)
            {
                label3.Text = "kazandınız";
                label3.BackColor = Color.Green;
                button6.BackColor = Color.Orange;
                userScore++;
                label1.Text = userScore.ToString();

            }
            else if (deger == 2)
            {
                label3.Text = "beraberlik";
                label3.BackColor = Color.Yellow;
                button5.BackColor = Color.Orange;
                pcScore++;
                label2.Text = pcScore.ToString();
                userScore++;
                label1.Text = userScore.ToString();
            }
            else if (deger == 3)
            {
                label3.Text = "kaybettiniz";
                label3.BackColor = Color.Red;
                button4.BackColor = Color.Orange;
                pcScore++;
                label2.Text = pcScore.ToString();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            userScore = 0;
            pcScore = 0;
            label1.Text = userScore.ToString();
            label2.Text = pcScore.ToString();

        }
    }
        
       
    
}
