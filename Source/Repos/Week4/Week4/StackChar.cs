using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    internal class StackChar
    {
        //member - data structure
        private int topPosition = 0; //next available element in the array
        private char[] arrayStack = new char[10];

        //constructor - leave it blank because already done the initialization

        //properties
        //no properties - data remain private

        //methods
        public void Push(char value) //add value to stack
        {
            arrayStack[topPosition] = value; //put item into next available draw
            topPosition++;
        }

        public char Pop()
        { 
            topPosition--;
            return arrayStack[topPosition];
        }

        public char Peek()
        { 
            return arrayStack[topPosition - 1];
        }

        public bool IsEmpty()
        {
            return topPosition == 0;
        }

        public bool IsFull ()
        {
            return topPosition == arrayStack.Length;
        }


    }
}
