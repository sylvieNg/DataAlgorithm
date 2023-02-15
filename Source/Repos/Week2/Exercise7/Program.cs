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
            string str1 = inputStr();
            char[] charArray = str1.ToCharArray();
            int[] numArray = new int[charArray.Length];
            for (int i = 0; i < charArray.Length; i++)
            {
                numArray[i] = int.Parse(charArray[i].ToString()); // convert each character to its corresponding integer value
            }

            if (isUnique(numArray) == true)
            {
                Console.WriteLine("All integers are unique");
            }
            else
            {
                Console.WriteLine("All integers are not unique");
            }
            Console.ReadKey();
        }

        static string inputStr()
        {
            Console.WriteLine("Enter text :");
            string input = Console.ReadLine();
            return input;
        }

        public static bool isUnique(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j]) //if same, no unique
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
