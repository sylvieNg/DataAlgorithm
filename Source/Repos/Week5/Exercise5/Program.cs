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
            int result = multiply(3, 5);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static int multiply(int x, int y)
        {
            if (y == 1)
                return x;
            else
                return x + multiply(x, y - 1);
        }
    }
}
