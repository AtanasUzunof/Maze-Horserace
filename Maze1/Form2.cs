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
    public partial class Form2 : Form
    {
        bool moveRight, moveLeft, moveUp, moveDown;
        int speed = 12;
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void BallMove_Tick(object sender, EventArgs e)
        {
            if (moveLeft == true)
            {
                Ball.Left -= speed;
            }
            if (moveRight == true)
            {
                Ball.Left += speed;
            }
            if (moveUp == true)
            {
                Ball.Top -= speed;

            }
            if (moveDown == true)
            {
                Ball.Top += speed;

            }
        }




        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void keysdown(object sender, KeyEventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "wall")
                {


                    if (e.KeyCode == Keys.Left)
                    {
                        moveLeft = true;
                        if (Ball.Left > x.Left && Ball.Left < x.Right - Ball.Width / 2 && Ball.Bottom > x.Top)
                        {
                            moveLeft = false;
                        }
                    }
                    if (e.KeyCode == Keys.Right)
                    {
                        moveRight = true;
                        if (Ball.Left < x.Right && Ball.Right > x.Left + Ball.Width / 2 && Ball.Bottom > x.Top)
                        {
                            moveRight = false;
                        }
                    }
                    if (e.KeyCode == Keys.Down)
                    {
                        moveDown = true;

                    }
                    if (e.KeyCode == Keys.Up)
                    {
                        moveUp = true;
                    }
                    if (Ball.Left + Ball.Width - 1 > x.Left && Ball.Left + Ball.Width + 5 < x.Left + x.Width + Ball.Width && Ball.Top + Ball.Width >= x.Top && Ball.Top < x.Top && Ball.Top < x.Top)
                    {
                        moveUp =false;
                    }
                }
            }
        }
                private void keysup(object sender, KeyEventArgs e)
                {
                    if (e.KeyCode == Keys.Left)
                    {
                        moveLeft = false;
                    }
                    if (e.KeyCode == Keys.Right)
                    {
                        moveRight = false;
                    }
                    if (e.KeyCode == Keys.Down)
                    {
                        moveDown = false;
                    }
                    if (e.KeyCode == Keys.Up)
                    {
                        moveUp = false;
                    }
                }
            }
    
}
