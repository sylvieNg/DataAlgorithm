using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackChar myStack = new StackChar(); //allocate the memory that looks like this stack class

            myStack.Push('a');
            System.Console.WriteLine(myStack.Pop());

            myStack.Push('b');
            myStack.Push('c');
            myStack.Push('d');

            Console.WriteLine(myStack.Peek()); 

            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());

            Console.ReadKey();
        }
    }
}
