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
            string str;
            string inputChar;
            char c;
            Console.WriteLine("Enter String :");
            str = Console.ReadLine();

            Console.WriteLine("Enter Char :");
            inputChar = Console.ReadLine();
            c = Convert.ToChar(inputChar);

            Console.WriteLine(occurrences(str, c));
            Console.ReadKey();
        }

        public static int occurrences(string s, char c)
        {
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {

                if (s[i] == c)
                    count++;
            }

            return count;
        }
    }
}
