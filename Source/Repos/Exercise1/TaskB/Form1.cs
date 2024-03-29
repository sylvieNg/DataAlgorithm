﻿using System;
using System.Collections;
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
        //private int nameSize = 20;
        //private int counter = 0;
        Customer myCustomers = new Customer();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //validation on text box is not empty and list box should not have this value
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !listBox1.Items.Contains(textBox1.Text))
            {
                //if elements in an array does not reach the max
                if (!myCustomers.IsFull())
                {
                    myCustomers.Enqueue(textBox1.Text);
                    listBox1.Items.Add(textBox1.Text);
                    label3.Text = myCustomers.totalCustomers().ToString(); //(counter + 1).ToString();
                    //counter++;
                }
                else
                {
                    MessageBox.Show("You have enter more than 20 names", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //Clear the text box value
                textBox1.Text = null;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //if the array is not empty
            if (!myCustomers.IsEmpty())
            {
                string name = myCustomers.Dequeue();
                listBox1.Items.Remove(name);
                label3.Text = myCustomers.totalCustomers().ToString();
                label4.Text = "Customer - " + name + " has been deleted.";
            }
            else
            {
                MessageBox.Show("The list is empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
