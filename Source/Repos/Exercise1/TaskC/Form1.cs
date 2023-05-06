using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaskC
{
    public partial class Form1 : Form
    {
        Customer myCustomers = new Customer();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(textBox1.Text) && !listBox1.Items.Contains(textBox1.Text)) && (!string.IsNullOrWhiteSpace(textBox2.Text)))
            {
                if (!myCustomers.IsFull())
                {
                    myCustomers.Enqueue(textBox1.Text, Convert.ToInt32(textBox2.Text));
                    listBox1.Items.Add(textBox1.Text);
                    listBox2.Items.Add(textBox2.Text);
                    label3.Text = myCustomers.totalCustomers().ToString();
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!myCustomers.IsEmpty())
            {
                (string name, int age) customer = myCustomers.Dequeue();
                listBox1.Items.Remove(customer.name);
                listBox2.Items.Remove(customer.age.ToString());
                label3.Text = myCustomers.totalCustomers().ToString();
                label6.Text = "Customer - " + customer.name + " ( age: " + customer.age + ") has been deleted.";
            }
            else
            {
                MessageBox.Show("The list is empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonReverse_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox3.Text))
            {
                int kElem = Convert.ToInt32(textBox3.Text);
                if (kElem > 0)
                {
                    //cleat the list box and do reverse
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    myCustomers.Reverse(kElem);
                }
                //display the customer information
                for (int i = 0; i < myCustomers.totalCustomers(); i++)
                {
                    (string name, string age) display = myCustomers.Display(i);
                    listBox1.Items.Add(display.name);
                    listBox2.Items.Add(display.age);
                }
            }
        }
    }
}
