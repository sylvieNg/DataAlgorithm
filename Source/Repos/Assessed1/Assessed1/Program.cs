using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessed1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[10];

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Student number " + (i+1));
                string name = inputName();
                int age = inputAge();
                students[i] = new Student(name, age, (i + 1).ToString());
            }

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i].GetInformation());
            }

            Console.ReadKey();
        }

        static string inputName()
        {
            Console.Write("Enter Name :");
            string input = Console.ReadLine();
            return input;
        }
        static int inputAge()
        {
            Console.Write("Enter Age :");
            string input = Console.ReadLine();
            int num = Convert.ToInt32(input);
            return num;
        }
    }
}
