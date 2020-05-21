using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace specialForm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       bool Flag=true;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 5)

             { label1.Show(); Flag = false;
            }
            else { label1.Visible = false; }

            if (!textBox2.Text.Contains("@"))
            

             { label2.Show();  Flag = false; }
            else { label2.Visible = false; }

            if (!checkBox1.Checked &&! checkBox2.Checked && !checkBox3.Checked)
            {
                label4.Show();
                Flag = false;

            }
            else { label4.Visible = false; }
            if (Flag == true)
            {
                label5.Show();
            }
                
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
