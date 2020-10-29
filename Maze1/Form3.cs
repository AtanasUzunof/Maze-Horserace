using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze1
{
    public partial class Form3 : Form
    {
        int h1, h2, h3;

        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            bool a = true;
            bool b = true;
            bool c = true;
            bool y = true;
            // horse 1 possitions
            if (horse1.Bounds.IntersectsWith(finish.Bounds) && b == true && c == true)
            {
                h1 = rnd.Next(0, 0);
                a = false;
                label1.Show();
            }
            if (horse1.Bounds.IntersectsWith(finish.Bounds) && b == true && c == false)
            {
                h1 = rnd.Next(0, 0);
                a = false;
                label2.Show();
            }
            if (horse1.Bounds.IntersectsWith(finish.Bounds) && b == false && c == true)
            {
                h1 = rnd.Next(0, 0);
                a = false;
                label2.Show();
            }
            if (horse1.Bounds.IntersectsWith(finish.Bounds) && b == false && c == false && a == true)
            {
                h1 = rnd.Next(0, 0);
                label3.Show();
            }
            // horse 2 possitions
            if (horse2.Bounds.IntersectsWith(finish.Bounds) && a == true && c == true)
            {
                h2 = rnd.Next(0, 0);
                b = false;
                label4.Show();
            }
            if (horse2.Bounds.IntersectsWith(finish.Bounds) && a == false && c == true)
            {
                h2 = rnd.Next(0, 0);
                b = false;
                label5.Show();
            }
            if (horse2.Bounds.IntersectsWith(finish.Bounds) && a == true && c == false)
            {
                h2 = rnd.Next(0, 0);
                b = false;
                label5.Show();
            }
            if (horse2.Bounds.IntersectsWith(finish.Bounds) && a == false && c == false && b == true)
            {
                h2 = rnd.Next(0, 0);
                label6.Show();
            }
            // horse 3 possitions
            if (horse3.Bounds.IntersectsWith(finish.Bounds) && a == true && b == true)
            {
                h3 = rnd.Next(0, 0);
                c = false;
                label7.Show();
            }
            if (horse3.Bounds.IntersectsWith(finish.Bounds) && a == true && b == false)
            {
                h3 = rnd.Next(0, 0);
                c = false;
                label8.Show();
            }
            if (horse3.Bounds.IntersectsWith(finish.Bounds) && a == false && b == true)
            {
                h3 = rnd.Next(0, 0);
                c = false;
                label8.Show();
            }
            if (horse3.Bounds.IntersectsWith(finish.Bounds) && a == false && b == false && c == true)
            {
                h3 = rnd.Next(0, 0);
                label9.Show();
            }
            if (a == true)
            {
                h1 = rnd.Next(4, 20);
                horse1.Left += h1;
            }
            if(b == true)
            {
                h2 = rnd.Next(4, 20);
                horse2.Left += h2;
            }
            if(c == true)
            {
                h3 = rnd.Next(4, 20);
                horse3.Left += h3;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
            {
            /*    Random rnd = new Random();
                int b = rnd.Next(4, 13);
                horse2.Left += b;
                if (horse1.Bounds.IntersectsWith(finish.Bounds) && h2 == 10 && h3 == 10)
                {
                    h1 = 20;
                }
                if (horse2.Bounds.IntersectsWith(finish.Bounds) && h1 == 10 && h3 == 10)
                {
                    h2 = 20;
                    horse2.Top = 197;
                    horse2.Left = 625;
                    timer2.Stop();
                }
                if (horse3.Bounds.IntersectsWith(finish.Bounds) && h1 == 10 && h2 == 10)
                {
                    h3 = 20;

                }*/
            }

        private void timer3_Tick(object sender, EventArgs e)
        {
            /* Random rnd = new Random();
             int c = rnd.Next(4, 13);
             horse3.Left += c;
             if (horse1.Bounds.IntersectsWith(finish.Bounds) && h2 == 10 && h3 == 10)
             {
                 h1 = 20;

             }
             if (horse2.Bounds.IntersectsWith(finish.Bounds) && h1 == 10 && h3 == 10)
             {
                 h2 = 20;

             }
             if (horse3.Bounds.IntersectsWith(finish.Bounds) && h1 == 10 && h2 == 10)
             {
                 h3 = 20;
                 horse3.Top = 332;
                 horse1.Left = 625;
                 timer3.Stop();
             }*/
        }
    }
}
