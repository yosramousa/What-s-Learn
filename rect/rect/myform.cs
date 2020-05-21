using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rect
{
    public partial class Rectangle : Form
    {
        Rectangle rect = new Rectangle();
        bool isMouseDown = false;
        public Rectangle(int v, int v1, int v2)
        {
            InitializeComponent();
        }
     public   int X;
        public int Y;

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.Blue), rect);
        }

        public Rectangle(IContainer components, Rectangle rect, bool isMouseDown)
        {
            this.components = components;
            this.rect = rect;
            this.isMouseDown = isMouseDown;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown == true)
            {
                rect.Location = e.Location;

                if (rect.Right > this.Width)
                {
                    rect.X = this.Width - rect.Width;
                }
                if (rect.Top < 0)
                {
                    rect.Y = 0;
                }
                if (rect.Left < 0)
                {
                    rect.X = 0;
                }
                if (rect.Bottom > this.Height)
                {
                    rect.Y = this.Height - rect.Height;
                }
                Refresh();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

    }
}
