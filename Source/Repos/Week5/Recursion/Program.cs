using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            printNumbers(5);
            Console.ReadKey();
        }

        static void printNumbers(int n)
        {
            if (n > 0)
            {
                Console.WriteLine(" n = {0} ", n);
                printNumbers(n - 1);
            }
            /* here */
            Console.WriteLine("\n Recursion Unfolding  --- n = {0} ", n);
        }

    }
}
