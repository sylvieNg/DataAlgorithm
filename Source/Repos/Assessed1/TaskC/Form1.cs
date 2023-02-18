using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskC
{
    public partial class Form1 : Form
    {
        private int nameSize = 10;
        private int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(textBox1.Text) && !listBox1.Items.Contains(textBox1.Text)) && (!string.IsNullOrWhiteSpace(textBox2.Text)))
            {
                if (counter < nameSize)
                {
                    listBox1.Items.Add(textBox1.Text);
                    listBox2.Items.Add(textBox2.Text);
                    label3.Text = (counter + 1).ToString();
                    counter++;
                }
                else
                {
                    MessageBox.Show("You have enter more than 10 names", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //Clear the text box value
                textBox1.Text = null;
                textBox2.Text = null;
            }
        }
    }
}
