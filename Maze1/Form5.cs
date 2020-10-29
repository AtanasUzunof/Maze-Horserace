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

    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }
    }
        public class Horse1
        {
            int h1, h2, h3;
            Random rnd = new Random();
            bool a = true;
            bool b = true;
            bool c = true;
            public void timerH()
            {
                if(a == true)
                {
                    h1 = rnd.Next(5,12);

                }
                if(b == true)
                {
                    h2 = rnd.Next(5, 12);
                    
                }
                if(c == true)
                {
                    h3 = rnd.Next(5, 12);

                }
            }
        
        } 
}
