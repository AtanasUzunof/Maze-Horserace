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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                player.Top = player.Top - 6;
            }
            if(e.KeyCode == Keys.Down)
            {
                player.Top += 6;
            }
            if (e.KeyCode == Keys.Left)
            {
                player.Left -= 6;
            }
            if(e.KeyCode == Keys.Right)
            {
                player.Left += 6;
            }
            if (player.Left > block1.Left && player.Left < block1.Right - player.Width / 2 && player.Bottom > block1.Top)
            {
                player.Left += 12;
            }
            if (player.Left < block1.Right && player.Right > block1.Left + player.Width/ 2 && player.Bottom > block1.Top)
            {
                player.Left -= 12;
            }
            if (player.Left + player.Width - 1 > block1.Left && player.Left + player.Width + 5 < block1.Left + block1.Width + player.Width && player.Top + player.Width >= block1.Top && player.Top < block1.Top && player.Top < block1.Top)
            {
                player.Top -= 6;
            }
            if (player.Left - player.Width + 1 < block1.Left && player.Left - player.Width - 5 > block1.Left - block1.Width - player.Width && player.Top - player.Width >= block1.Top && player.Top > block1.Top && player.Top > block1.Top)
            {
                player.Top += 6;
            }
            /*  if (player.Bottom > block1.Top && player.Left < block1.Right && player.Right > block1.Left)
              {

              }*/
        }
    }
}
