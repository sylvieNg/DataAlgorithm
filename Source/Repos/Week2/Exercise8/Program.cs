using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = inputStr();
            string str2 = inputStr();
            if (arePermutation(str1, str2))
            {
                Console.WriteLine("Permutation");
            }
            else
            {
                Console.WriteLine("No permutation");
            }
            Console.ReadKey();
        }

        static string inputStr()
        {
            Console.WriteLine("Enter text :");
            string input = Console.ReadLine();
            return input;
        }

        static bool arePermutation(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }

            char[] ch1 = str1.ToCharArray();
            char[] ch2 = str2.ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            for (int i = 0; i < str1.Length; i++)
            {
                if (ch1[i] != ch2[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
