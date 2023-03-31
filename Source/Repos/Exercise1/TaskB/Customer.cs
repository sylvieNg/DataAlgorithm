using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace TaskB
{
    internal class Customer
    {
        private readonly int maxsize = 20;
        private string[] customers;
        private int head = 0;

        private int tail = 0;
        private int customerNum;

        public Customer()
        {
            customers = new string[maxsize];
        }

        public Customer(int size)
        {
            maxsize = size;
            customers = new string[maxsize];
        }

        public void Enqueue(string value)
        {
            // insert code
            customerNum++;
            customers[tail] = value;
            if (++tail == maxsize)
            {
                tail = 0;
            }
        }

        public string Dequeue()
        {
            // insert code, should return value removed
            string headItem;
            customerNum--;
            headItem = customers[head];

            if (++head == maxsize)
            {
                head = 0;
            }
            return headItem;
        }

        public string Peek()
        {
            // insert code, should return first value
            return customers[tail - 1];
        }

        public bool IsEmpty()
        {
            //insert code, should return true/false
            return customerNum == 0;
        }

        public bool IsFull()
        {
            // insert code, true/false
            return customerNum == maxsize;
        }

        public int totalCustomers()
        {
            return customerNum;
        }
    }
}
