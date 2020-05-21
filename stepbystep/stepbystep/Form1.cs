using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stepbystep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void red_SelectedItemChanged(object sender, EventArgs e)
        {
            label3.ForeColor = Color.FromName(domainupdown.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void n1_ValueChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(numericupdown.Value);
            label3.Font = new Font( "tohama", x);

        }
    }
}
