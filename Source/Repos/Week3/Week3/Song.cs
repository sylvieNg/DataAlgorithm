using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    internal class Song
    {
        private string title, singer;

        public Song(string title, string singer)
        {
            this.title = title;
            this.singer = singer;
        }

        public Song(string title)
        { 
            this.title = title;
            this.singer = "unknown";
        }

        public string Title //property(s)
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public string Singer
        {
            get { return this.singer; }
            set { this.singer = value; }
        }

        //Methods
        public void Display()
        {
            Console.WriteLine("Song {0} by {1}", this.title, this.singer);
        }
    }
}
