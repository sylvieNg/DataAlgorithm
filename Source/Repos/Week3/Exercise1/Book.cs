using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Book
    {
        private string title;
        private Person author;
        private int publicationYear = 2000;

        public Book(string title)
        { 
            this.title = title;
            this.author = new Person("unknown");
        }

        public Book(string title, Person _author, int _publicationYear)
        {
            this.title = title;
            this.author = _author;
            this.publicationYear = _publicationYear;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public Person Author
        {
            get { return author; }
            set { author = value; }
        }

        public int PublicationYear
        {
            get { return publicationYear; }
            set { publicationYear = value; }
        }

        public string GetSummary(string title, Person detail, int year)
        {
            return "Title: " + title + " Author name: " + detail.Name + " Author age: " + detail.Age + " Publication Year: " + year;
        }
    }
}
