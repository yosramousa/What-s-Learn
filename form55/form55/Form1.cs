using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form55
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int index;
        private void btnadd_Click(object sender, EventArgs e)
        {
            //bool flag = true;
            //if(!textBox1.Text==null && !textBox2.Text==null &&!dateTimePicker1.Text==null)
            {
                ListViewItem itmes = new ListViewItem(textBox1.Text);
                itmes.SubItems.Add(textBox2.Text);
                itmes.SubItems.Add(dateTimePicker1.Value.ToString("dd-mm-yyyy"));
                listView1.Items.Add(itmes);
                textBox1.Text = null;
                textBox2.Text = null;
                dateTimePicker1.Text = null;

            }
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            index = listView1.SelectedIndices[0];
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text.ToString();
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text.ToString();
            dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[2].Text.ToString();

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            listView1.Items[index].SubItems[0].Text = textBox1.Text;
            listView1.Items[index].SubItems[1].Text = textBox2.Text;
            listView1.Items[index].SubItems[2].Text = dateTimePicker1.Text;




        }
    }
}
