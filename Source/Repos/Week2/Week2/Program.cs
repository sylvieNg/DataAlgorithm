using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            num1 = inputInt();
            num2 = inputInt();

            int smallestResult = smallest(num1, num2);
            Console.WriteLine("Smallest number is : " + smallestResult);

            int[] numArray = new int[5];
            numArray = inputArray(numArray);
            reverse(numArray);

            Console.ReadKey();

        }

        static int smallest(int x, int y)
        {
            if (x < y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }

        static int inputInt()
        {
            Console.WriteLine("Enter Number :");
            string input1 = Console.ReadLine();
            int num = Convert.ToInt32(input1);
            return num;
        }

        static int[] inputArray(int[] numArray)
        {
            int enter;
            for (int i = 0; i < numArray.Length; i++)
            {
                enter = inputInt();
                numArray[i] = enter;
            }
            return numArray;
        }

        static void reverse(int[] values)
        {
            for (int i = values.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("Number in reverse : " + values[i]);
            }
        }



    }
}
