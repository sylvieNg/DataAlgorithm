using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TaskB
{
    public partial class Form1 : Form
    {
        private int nameSize = 20;
        private int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !listBox1.Items.Contains(textBox1.Text))
            {
                if (counter < nameSize)
                {
                    listBox1.Items.Add(textBox1.Text);
                    label3.Text = (counter + 1).ToString();
                    counter++;
                }
                else
                {
                    MessageBox.Show("You have enter more than 20 names", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //Clear the text box value
                textBox1.Text = null;
            }
                
        }
    }
}
