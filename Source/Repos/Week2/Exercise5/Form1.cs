using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise5
{
    public partial class Form1 : Form
    {
        private string[] numArray;
        private int num1, num2, result;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            numArray = textBox1.Text.Split(' ');
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = 0;
            if (numArray != null)
            {
                if (numArray.Length > 1)
                {
                    num1 = Convert.ToInt32(numArray[0]);
                    num2 = Convert.ToInt32(numArray[2]);
                    if (numArray[1] == "+")
                    {
                        result = num1 + num2;
                    }
                    else if (numArray[1] == "-")
                    {
                        result = num1 - num2;
                    }
                    else if (numArray[1] == "*")
                    {
                        result = num1 * num2;
                    }
                    else
                    {
                        return;
                    }

                    textBox2.Text = result.ToString();
                }
            }
        }
    }
}
