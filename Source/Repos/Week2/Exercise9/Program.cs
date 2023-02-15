using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = inputStr();

            if (hasUniqueChar(str1) == true)
            {
                Console.WriteLine("The text has unique characters");
            }
            else
            {
                Console.WriteLine("The text has duplicate characters");
            }
            Console.ReadKey();
        }

        static string inputStr()
        {
            Console.WriteLine("Enter text :");
            string input = Console.ReadLine();
            return input;
        }

        static bool hasUniqueChar(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[i] == str[j]) //if same, no unique
                    {
                        return false;
                    }
                }
            }
            //else is unique
            return true;
        }
    }
}
