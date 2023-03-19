using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;

            Console.WriteLine("num1 is " + num1);
            Console.WriteLine("num2 is " + num2);
            Console.WriteLine("Calling Process, num2 passed by ref :");
            process(num1, ref num2);
            Console.WriteLine("num1 is " + num1);
            Console.WriteLine("num2 is " + num2);
            Console.ReadKey();
        }

        static void process(int x, ref int y)
        {
            x = x + 5;
            y = y + 5;
        }

    }
}
