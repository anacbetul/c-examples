using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TKM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int skor = 0;
        int bot = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            Random random = new Random();
            int deger;
            deger = random.Next(1, 4);

            if (deger == 1)
            {
                label4.Text = "Berabere";
                button1.BackColor = Color.Gray;
            }
            else if (deger == 2)
            {
                label4.Text = "Kaybettiniz";
                button2.BackColor = Color.Red;
                bot++;
                label2.Text = bot.ToString();
            }
            else if (deger == 3)
            {
                label4.Text = "Kazandınız";
                button3.BackColor = Color.Green;
                skor++;
                label1.Text = skor.ToString();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            Random random = new Random();
            int deger;
            deger = random.Next(1, 4);

            if (deger == 1)
            {
                label4.Text = "Kazandınız";
                button1.BackColor = Color.Green;
                skor++;
                label1.Text = skor.ToString();
            }
            else if (deger == 2)
            {
                label4.Text = "Berabere";
                button2.BackColor = Color.Gray;
            }
            else if (deger == 3)
            {
                label4.Text = "Kaybettiniz";
                button3.BackColor = Color.Red;
                bot++;
                label2.Text = bot.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            Random random = new Random();
            int deger;
            deger = random.Next(1, 4);

            if (deger == 1)
            {
                label4.Text = "Kaybettiniz";
                button1.BackColor = Color.Red;
                bot++;
                label2.Text = bot.ToString();
            }
            else if (deger == 2)
            {
                label4.Text = "Kazandınız";
                button2.BackColor = Color.Green;
                skor++;
                label1.Text = skor.ToString();
            }
            else if (deger == 3)
            {
                label4.Text = "Berabere";
                button3.BackColor = Color.Gray;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bot == 3)
            {
                label4.Text = "PC Kazandı";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            else if (skor == 3)
            {
                label4.Text = "Tebrikler Kazandın!!";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
        }
    }
}
