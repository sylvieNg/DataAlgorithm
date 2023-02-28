using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    internal class IntQueue
    {
        private readonly int maxsize = 10;
        private int[] store;
        private int head = 0;

        private int tail = 0;
        private int numItems;

        public IntQueue()
        {
            store = new int[maxsize];
        }

        public IntQueue(int size)
        {
            maxsize = size;
            store = new int[maxsize];
        }

        public void Enqueue(int value)
        {
            // insert code
            numItems++;
            store[tail] = value;
            if (++tail == maxsize)
            { 
                tail = 0;
            }
        }

        public int Dequeue()
        {
            // insert code, should return value removed
            int headItem;
            numItems--;
            headItem = store[head];

            if (++head == maxsize)
            { 
                head = 0;
            }
            return headItem;
        }

        public int Peek()
        {
            // insert code, should return first value
            return store[tail - 1];
        }

        public bool IsEmpty()
        {
            //insert code, should return true/false
            return numItems == 0;
        }

        public bool IsFull()
        {
            // insert code, true/false
            return numItems == maxsize;
        }

    }
}
