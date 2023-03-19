using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", dec(dec(10)));
            Console.WriteLine("{0}", inc(inc(inc(inc(2)))));
            Console.WriteLine("{0}", inc(dec(inc(inc(2)))));

            int result = multiply(3, 5);
            Console.WriteLine(result);

            Console.ReadKey();
        }

        static int inc(int x)
        {
            return x + 1;
        }

        static int dec(int x)
        {
            return x - 1;
        }

        static int multiply(int x, int y)
        {
            if (y == 1)
                return x;
            else
                return x + multiply(x, dec(y));
        }

    }
}
