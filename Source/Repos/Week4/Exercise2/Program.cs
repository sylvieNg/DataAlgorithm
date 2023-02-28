using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntStack mystack = new IntStack();

            mystack.Push(10);
            System.Console.WriteLine(mystack.Pop());

            mystack.Push(20);
            mystack.Push(30);
            mystack.Push(40);

            Console.WriteLine(mystack.Pop());
            Console.WriteLine(mystack.Pop());
            Console.WriteLine(mystack.Pop());

            Random randgen = new Random();
            while (!mystack.IsFull())
            {
                mystack.Push(randgen.Next(100));
            }

            while (!mystack.IsEmpty())
            {
                Console.WriteLine(mystack.Pop());
            }


            Console.ReadKey();

        }
    }
}
