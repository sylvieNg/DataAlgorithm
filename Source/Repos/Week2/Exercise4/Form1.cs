using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise4
{
    public partial class Form1 : Form
    {
        private int num1, num2, result;
        private bool sumFlag, minusFlag, multiplyFlag, powerFlag;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            sumFlag = false;
            minusFlag = true;
            multiplyFlag = false;
            powerFlag = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            sumFlag = false;
            minusFlag = false;
            multiplyFlag = true;
            powerFlag = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            sumFlag = false;
            minusFlag = false;
            multiplyFlag = false;
            powerFlag = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = 0;
            if (sumFlag)
            {
                result = num1 + num2;
            }
            else if (minusFlag)
            {
                result = num1 - num2;
            }
            else if (multiplyFlag)
            {
                result = num1 * num2;
            }
            else if (powerFlag)
            {
                result = 1;
                for (int i = 1; i <= num2; i++)
                {

                    result = result * num1;
                }
            }
            else
            {
                return;
            }
            textBox3.Text = result.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(textBox2.Text);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            sumFlag = true;
            minusFlag = false;
            multiplyFlag = false;
            powerFlag = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);
        }
    }
}
