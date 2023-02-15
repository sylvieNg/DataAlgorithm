using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise2a            
            int number;
            string input;
            string result;

            Console.WriteLine("Enter Number :"); //display a string “ “
            input = Console.ReadLine();  //wait for user a value and hit CR
            number = Convert.ToInt32(input); //convert to an int and assign

            if (number < 50)
            {
                result = "FAIL";
            }
            else if (number >= 50 && number <= 59)
            {
                result = "PASS";
            }
            else if (number >= 60 && number <= 69)
            {
                result = "MERIT";
            }
            else
            {
                result = "DISTINCTION";
            }

            Console.WriteLine("Number is : " + number + " and the result is " + result);
            Console.ReadKey();  //waits for a key to press before ending

            //Exercise2b
            int score;
            int counter = 0;
            string inputScore;
            string result2;
            while (counter <= 4)
            {
                Console.WriteLine("Enter Number :");
                inputScore = Console.ReadLine();
                score = Convert.ToInt32(inputScore);

                if (score < 50)
                {
                    result2 = "FAIL";
                }
                else if (score >= 50 && score <= 59)
                {
                    result2 = "PASS";
                }
                else if (score >= 60 && score <= 69)
                {
                    result2 = "MERIT";
                }
                else
                {
                    result2 = "DISTINCTION";
                }
                Console.WriteLine("Number is : " + score + " and the result is " + result2);
                counter++;
            }

            //Exercise2c
            int[] scores = new int[4] { 60, 61, 65, 68 };
            int total_score = 0;
            int average_score = 0;
            string result3;
            for (int i = 0; i < scores.Length; i++)
            {
                total_score = total_score + scores[i];
            }

            average_score = total_score / scores.Length;

            if (average_score < 50)
            {
                result3 = "FAIL";
            }
            else if (average_score >= 50 && average_score <= 59)
            {
                result3 = "PASS";
            }
            else if (average_score >= 60 && average_score <= 69)
            {
                result3 = "MERIT";
            }
            else
            {
                result3 = "DISTINCTION";
            }
            Console.WriteLine("Number is : " + average_score + " and the result is " + result3);

            //Exercise2d

        }

    }
}
