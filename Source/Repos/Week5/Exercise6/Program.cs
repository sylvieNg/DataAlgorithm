using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = power(3, 2);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static int power(int x, int y)
        {
            if (y == 1)
                return x;
            else
                return x * power(x, dec(y));
        }

        static int inc(int x)
        {
            return x + 1;
        }

        static int dec(int x)
        {
            return x - 1;
        }
    }
}
