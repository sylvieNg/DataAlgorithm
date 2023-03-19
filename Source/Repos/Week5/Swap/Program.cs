using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;

            Console.WriteLine("num1 is " + num1);
            Console.WriteLine("num2 is " + num2);
            Console.WriteLine("Calling swap:");
            swap(ref num1, ref num2);
            Console.WriteLine("num1 is " + num1);
            Console.WriteLine("num2 is " + num2);
            add(num1, num2);
            Console.WriteLine("num1 is " + num1);
            Console.WriteLine("num2 is " + num2);
            Console.ReadKey();
        }

        static void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static void add(int x, int y)
        {
            x = x + 10;
            y = y + 5;
        }
    }
}
