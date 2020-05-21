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
    public partial class form2 : Form
    {
        public event EventHandler FormateChanged;
        public FontFamily fontFamily;
        public int fontsize;
    
      
        public form2()
        {
            
            InitializeComponent();
        }
        public Color Color
        {
            get
            {
                if (radioButton1.Checked)
                    return Color.Red;
                else if (radioButton2.Checked)
                    return Color.Blue;
                else
                    return Color.Black;
            }
        }
        public FontStyle font
        {
            get
            {
                FontStyle f = FontStyle.Regular;

                if (checkBox1.Checked)
                {
                    f = f ^ FontStyle.Bold;
                }
                //else
                //{ f = f ^ FontStyle.Bold; }
                if (checkBox2.Checked)
                {
                    f = f ^ FontStyle.Italic;
                }
                //else
                //{ f = f ^ FontStyle.Italic; }
                Console.WriteLine(f);
                if (checkBox3.Checked)
                {
                    f = f ^ FontStyle.Underline;
                }
                //else
                //{ f = f ^ FontStyle.Underline; }
                Console.WriteLine(f);
                Font F = new Font(new FontFamily(comboBox1.SelectedItem.ToString()), Convert.ToInt32(domainUpDown1.Text), f);
                return f;
            }
        }

        private void trainees_Load(object sender, EventArgs e)
        {

            foreach (var item in FontFamily.Families)
            {
                comboBox1.Items.Add(item.Name);
            }
            for (int i = 2; i <= 100; i += 2)
            {
                domainUpDown1.Items.Add(i);
            }
        }
        private void btnapply_Click(object sender, EventArgs e)
        {



            FormateChanged(this, e);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fontFamily = (FontFamily)(comboBox1.SelectedValue);
        }



        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            fontsize = Convert.ToInt32(domainUpDown1.Text);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
{

}

private void label1_Click(object sender, EventArgs e)
{

}





private void groupBox1_Enter(object sender, EventArgs e)
{

}

private void radioButton2_CheckedChanged(object sender, EventArgs e)
{

}




private void radioButton1_CheckedChanged(object sender, EventArgs e)
{

}


    }
}
