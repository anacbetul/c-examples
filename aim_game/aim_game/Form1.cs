using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aim_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int time = 60;
        int heal = 3;
        int score = 0;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Start();
            panel1.Enabled = true;

            Random rand = new Random();

            score++;
            label2.Text = score.ToString();
            int point_x = rand.Next(100, this.ClientSize.Width - pictureBox1.Width);
            int point_y = rand.Next(100, this.ClientSize.Height - pictureBox1.Height);

            pictureBox1.Location = new Point(point_x, point_y);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;

            if (time == 0)
            {
                MessageBox.Show($"Süre bitti, Skorunuz: {score}");
                timer1.Stop();
                Application.Exit();
            }
            label4.Text = time.ToString();
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            heal--;
            label5.Text = heal.ToString();
            if (heal == 0)
            {
                MessageBox.Show($"Kaybettiniz, Skorunuz: {score}");
                timer1.Stop();
                Application.Restart();
            }
        }
    }
}
