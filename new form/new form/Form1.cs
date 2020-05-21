using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_form
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnformat_Click(object sender, EventArgs e)
        {    if(textbox2.Text !=null || textbox2.Text != " ")
            {
                Hide();
                form2 form2 = new form2();
                form2.FormateChanged += Form2_FormateChanged;
                form2.Show();

            }
            

        }

        private void Form2_FormateChanged(object sender, EventArgs e)
        {
            textbox2.ForeColor = ((form2)sender).Color;
            textbox2.Font = ((form2)sender).Font;
            this.Show();








            ((form2)sender).Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
