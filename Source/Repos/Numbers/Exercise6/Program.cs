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
            int[] arr1 = { 1,2,3,4,5,6,7 };
            int[] arr2 = { 7,1,6,2,5,3,4 };

            if (equalArray(arr1, arr2))
            {
                Console.WriteLine("Yes");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No");
                Console.ReadKey();
            }
        }

        public static bool equalArray(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
            {
                return false;
            }

            Array.Sort(arr1);
            Array.Sort(arr2);

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
