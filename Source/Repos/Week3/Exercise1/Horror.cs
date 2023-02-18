using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Horror : Book
    {
        public Horror(string title) : base(title)
        {
            base.Author = new Person("Stephen King");
        }
    }

    internal class Comedy : Book
    {
        public Comedy(string title) : base(title)
        {
            base.Author = new Person("HAHAHA");
        }
    }
}
