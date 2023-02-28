using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntQueue mystack = new IntQueue();

            Random randgen = new Random();
            while (!mystack.IsFull())
            {
                mystack.Enqueue(randgen.Next(100));
            }

            while (!mystack.IsEmpty())
            {
                Console.WriteLine(mystack.Dequeue());
            }


            Console.ReadKey();
        }
    }
}
