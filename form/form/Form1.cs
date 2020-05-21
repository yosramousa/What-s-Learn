using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form
{
    public partial class Form1 : Form
    {
        bool press=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        { 
            press = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        { if (e.Button == MouseButtons.Left)
            {
                Graphics g = this.CreateGraphics();
                g.DrawEllipse(Pens.Black,e.X-10, e.Y-10,20,20);
            
            }
      if( e.Button == MouseButtons.Right)
            {

                Graphics g = this.CreateGraphics();
                g.DrawEllipse(Pens.White, e.X - 10, e.Y - 10, 20, 20);

            }
           


            }
        

        

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            press = false;
        }
    }
}
