using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star
{
    internal class Program
    {
        static void Main(string[] args)
        {
            printStar(5);
            Console.ReadKey();
        }

        static void printStar(int n)
        {
            if (n > 0)
            {
                Console.Write("*");
                printStar(n - 1);
            }
        }
    }
}
