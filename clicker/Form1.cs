using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int primo = 0;
        int fate = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            primo++;
            label2.Text = primo.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(fate > 0)
            {
                timer2.Start();
                fate--;
                pictureBox5.Visible = true;
                label1.Text= fate.ToString();
            }
            else
            {
                MessageBox.Show("Yeterli Sayıda Fate Yok");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(primo >= 160)
            {
                primo -= 160;
                fate++;
                label1.Text = fate.ToString();
            }
            else
            {
                MessageBox.Show("Yeterli sayıda primogem yok");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            pictureBox5.Visible = false;
            pictureBox6.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible= false;
        }
    }
}
