using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song song1, song2;
            song1 = new Song("Hello", "Adele");
            song2 = new Song("ABC");

            Album album1 = new Album("Melody");
            album1.AddTrack(song1);
            album1.AddTrack(song2);

            album1.Display();

            Console.ReadKey();
        }
    }
}
