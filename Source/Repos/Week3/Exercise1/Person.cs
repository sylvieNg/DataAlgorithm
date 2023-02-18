using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Person
    {
        private int age;
        private string name;

        public Person(string name)
        {
            this.name = name;
            age = 18; //default age
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        //property for name            
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void Display()
        {
            Console.WriteLine("Person details {0} with age {1}", this.name, this.age);
        }

    }
}
