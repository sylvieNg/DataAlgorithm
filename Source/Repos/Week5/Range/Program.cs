using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            range(5, 10);
            Console.ReadKey();
        }

        static void range(int start, int end)
        {
            if (start <= end)
            {
                Console.WriteLine(" n = {0} ", start);
                range(start + 1, end);
            }
        }
    }
}
