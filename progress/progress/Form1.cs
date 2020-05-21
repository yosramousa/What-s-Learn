using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            //trackBar1.Value.ToString();
            //progressBar1.Value += 10;
            //if (trackBar1.Value != null)
            //{


            //}
            progressBar1.MarqueeAnimationSpeed = trackBar1.Value * 10;
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            progressBar1.PerformStep();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }
    }
    }

