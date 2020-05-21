using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
           for(int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {

                checkedListBox2.Items.Add(checkedListBox1.CheckedItems[i]);
                
                 checkedListBox1.Items.Remove(checkedListBox1.CheckedItems[i]);
                i--;
            }

            

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {

                checkedListBox2.Items.Add(checkedListBox1.Items[i]);

                checkedListBox1.Items.Remove(checkedListBox1.Items[i]);
                i--;
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox2.CheckedItems.Count; i++)
            {

                checkedListBox1.Items.Add(checkedListBox2.CheckedItems[i]);

                checkedListBox2.Items.Remove(checkedListBox2.CheckedItems[i]);
                i--;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {

                checkedListBox1.Items.Add(checkedListBox2.Items[i]);

                checkedListBox2.Items.Remove(checkedListBox2.Items[i]);
                i--;
            }
        }
    }
}
