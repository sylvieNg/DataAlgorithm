using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskA
{
    internal class Student
    {
        private string name;
        private int age;
        private string id;

        public Student(string _name, int _age, string _id) //constructor
        {
            this.name = _name;
            this.id = _id;
            this.age = _age;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        //method
        public string GetInformation()
        {
            // to be completed
            return "Student " + this.id + " name " + this.name + " with the age " + this.age;
        }

    }
}
