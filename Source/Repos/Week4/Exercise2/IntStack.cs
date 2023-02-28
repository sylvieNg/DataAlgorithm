using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class IntStack
    {
        private const int maxsize = 10;
        private int top = 0;
        private int[] array = new int[maxsize];

        public void Push(int value)
        {
            // insert code here 
            array[top] = value;
            top++;
        }

        public int Pop()
        {

            return array[--top];
        }

        public int Peek()
        {
            // insert code here
            return array[top - 1];
        }

        public bool IsEmpty()
        {
            return top == 0;
        }

        public bool IsFull()
        {
            return top == maxsize;
        }

        // return a string with the full stack content
        public string Print()
        {
            StringBuilder output = new StringBuilder();
            for (int i = top - 1; i >= 0; i--)
                output.Append(array[i] + Environment.NewLine);
            return output.ToString();
        }

    }
}
