using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            num1 = inputInt();
            num2 = inputInt();

            // Call sum function pass int vars
            int result = sum(num1, num2);
            Console.WriteLine("Sum is : " + result);

            Console.WriteLine("This is exercise A");
            int maxResult = max(num1, num2);
            Console.WriteLine("Max is : " + maxResult);

            Console.WriteLine("This is exercise B");
            int smallestNum = maxResult != num1 ? num1 : num2;
            int powerNum = calPower(smallestNum, maxResult);
            Console.WriteLine("Power is : " + powerNum);

            Console.WriteLine("This is exercise C");
            double mean = getAverage();
            Console.WriteLine("Mean is : " + mean);

            Console.WriteLine("This is exercise D");
            double[] tempArray = new double[10];
            tempArray = inputArray(tempArray);
            double meanTemp = getAverageTemp(tempArray);
            double minValue = getMinValue(tempArray);
            double maxValue = getMaxValue(tempArray);
            Console.WriteLine("Mean temperature is : " + meanTemp);
            Console.WriteLine("Min temperature is : " + minValue);
            Console.WriteLine("Max temperature is : " + maxValue);

            Console.ReadKey();  //waits for a key to press before ending
        }

        static int inputInt()
        {
            Console.WriteLine("Enter Number :");
            string input = Console.ReadLine();
            int num = Convert.ToInt32(input);
            return num;
        }

        static int sum(int x, int y)
        {
            return x + y;
        }

        //ExerciseA
        static int max(int x, int y)
        {
            if (x < y)
            {
                return y;
            }
            else
            {
                return x;
            }
        }

        //ExerciseB
        static int calPower(int x, int y)
        {
            int power = 1;
            for (int i = 1; i <= y; i++)
            {
                power = power * x;
            }
            return power;
        }
        //ExerciseC
        static double getAverage()
        {
            int counter = 0;
            double sum = 0;
            bool exit = false;
            do
            {
                Console.WriteLine("Enter number or type \"done\" to exit");
                string enter = Console.ReadLine();
                if (enter.Trim().ToLower() != "done")
                {
                    double num = Convert.ToDouble(enter);
                    sum += num;
                    counter++;
                }
                else exit = true;

            } while (!exit);

            double average = sum / counter;
            return average;

        }

        //ExerciseD
        static double inputDouble()
        {
            Console.WriteLine("Enter Number :");
            string input = Console.ReadLine();
            double num = Convert.ToDouble(input);
            return num;
        }
        static double[] inputArray(double[] numArray)
        {
            double enter;
            for (int i = 0; i < numArray.Length; i++)
            {
                enter = inputDouble();
                numArray[i] = enter;
            }
            return numArray;
        }
        static double getAverageTemp(double[] tempArray)
        {
            double sum = 0;
            for (int i = 0; i < tempArray.Length; i++)
            {
                sum += tempArray[i];
            }
            double average = sum / tempArray.Length;
            return average;

        }

        static double getMinValue(double[] tempArray)
        {
            double temp = 0.0;
            for (int i = 0; i < tempArray.Length; i++)
            {
                if (i == 0)
                {
                    temp = tempArray[i];
                }
                else
                {
                    temp = minTemp(temp, tempArray[i]);
                }
            }
            return temp;

        }

        static double getMaxValue(double[] tempArray)
        {
            double temp = 0.0;
            for (int i = 0; i < tempArray.Length; i++)
            {
                if (i == 0)
                {
                    temp = tempArray[i];
                }
                else
                {
                    temp = maxTemp(temp, tempArray[i]);
                }
            }
            return temp;

        }

        static double maxTemp(double x, double y)
        {
            if (x < y)
            {
                return y;
            }
            else
            {
                return x;
            }
        }

        static double minTemp(double x, double y)
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
    }
}
