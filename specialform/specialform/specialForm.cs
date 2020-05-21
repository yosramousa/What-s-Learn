using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace specialform
{
    public partial class specialForm : Form
    {
        public specialForm()
        {
            InitializeComponent();
        }
        public int value;
        public int result;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void radior1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void btnconvert_Click(object sender, EventArgs e)
        {
            if (radior1.Checked == true)
            {
             double x= ( double.Parse( textBox1.Text))/ 1000;
                textBox2.Text = x.ToString();

            }
            else if (radior2.Checked == true){
                double x = (double.Parse(textBox1.Text)) / 1609.344;
                textBox2.Text = x.ToString();
            }

            else if (radior3.Checked == true)
            {
                double x = (double.Parse(textBox1.Text)) *1609.344;
                textBox2.Text = x.ToString();
            }
        }
    }
}
