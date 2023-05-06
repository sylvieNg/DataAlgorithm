using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskC
{
    internal class Customer
    {
        private readonly int maxsize = 10;
        private string[] customerNames;
        private int[] customerAges;
        private int head = 0;

        private int tail = 0;
        private int customerNum;

        private int topPosition;

        public Customer()
        {
            customerNames = new string[maxsize];
            customerAges = new int[maxsize];
        }

        public Customer(int size)
        {
            maxsize = size;
            customerNames = new string[maxsize];
            customerAges = new int[maxsize];
        }

        public void Enqueue(string name, int age)
        {
            // insert code
            customerNum++;
            customerNames[tail] = name;
            customerAges[tail] = age;
            if (++tail == maxsize)
            {
                tail = 0;
            }
        }

        public (string, int) Dequeue()
        {
            // insert code, should return value removed
            string itemName;
            int itemAge;
            customerNum--;
            itemName = customerNames[head];
            itemAge = customerAges[head];

            if (++head == maxsize)
            {
                head = 0;
            }
            return (itemName, itemAge);
        }

        public (string, int) Peek()
        {
            // insert code, should return first value
            return (customerNames[tail - 1], customerAges[tail-1]);
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

        public void Reverse(int elem)
        {
            string[] tempNames = new string[maxsize];
            int[] tempAges = new int[maxsize];
            topPosition = elem;

            //from first to elem
            for (int i = 0; i < elem; i++)
            {
                tempNames[i] = customerNames[i];
                tempAges[i] = customerAges[i];
            }
            //reverse the order of the elem
            for (int i = 0; i < elem; i++)
            {
                topPosition--;
                customerNames[i] = tempNames[topPosition];
                customerAges[i] = tempAges[topPosition];
            }
        }

        public (string, string) Display(int value)
        {
            return (customerNames[value], customerAges[value].ToString());
        }
    }
}
