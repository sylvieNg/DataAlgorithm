using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // initialize class Student in an array
            Student[] students = new Student[10];

            //using for loop to ask for user input
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Student number " + (i+1));
                string name = inputName();
                int age = inputAge();
                students[i] = new Student(name, age, (i + 1).ToString());
            }

            // for loop to display the information
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i].GetInformation());
            }

            Console.ReadKey();
        }

        //function for inputing name
        static string inputName()
        {
            Console.Write("Enter Name :");
            string input = Console.ReadLine();
            return input;
        }
        //function for inputing age
        static int inputAge()
        {
            Console.Write("Enter Age :");
            string input = Console.ReadLine();
            int num = Convert.ToInt32(input);
            return num;
        }
    }
}
