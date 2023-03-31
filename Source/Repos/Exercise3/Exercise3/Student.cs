using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Student
    {
        private int id;
        private string name;
        private bool status;

        public Student(int id, string name, bool status)
        {
            this.id = id;
            this.name = name;
            this.status = status;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
