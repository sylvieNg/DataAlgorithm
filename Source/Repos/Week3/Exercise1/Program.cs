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
            Person person1 = new Person("David");  //test constructor – 1 argument
            Console.WriteLine("Name is :" + person1.Name); //test Name property
            person1.Age = 30;       //test Age property

            Person person2 = new Person("Shi Yun", 28);
            person2.Display();



            Book[] books = new Book[3];  //declare an array of 3 Books

            books[0] = new Book("Moby Dick");
            books[0].Author = new Person("Herman Melville");
            books[1] = new Book("The Creeping");
            books[2] = new Book("Harry Potter");
            books[2].Author = new Person("I don't know");
            books[2].PublicationYear = 2013;

            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine(books[i].GetSummary(books[i].Title, books[i].Author, books[i].PublicationYear));
            }

            Book[] varietyBooks = new Book[2];
            varietyBooks[0] = new Horror("Ghost");
            varietyBooks[1] = new Comedy("LOL");

            for (int i = 0; i < varietyBooks.Length; i++)
            {
                Console.WriteLine(varietyBooks[i].GetSummary(varietyBooks[i].Title, varietyBooks[i].Author, varietyBooks[i].PublicationYear));
            }


            Console.ReadKey();


        }
    }
}
