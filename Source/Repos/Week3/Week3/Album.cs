using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    internal class Album
    {
        private string title;
        private Song[] track;
        private int trackNum = 0;

        public Album(string title) //constructor
        {
            this.title = title;
            this.track = new Song[20]; //max of 20 songs
        }

        public string Title
        { 
            get { return this.title; }
            set { this.title = value; }
        }

        public int TrackNum
        { 
            get { return this.trackNum; }
            set { this.trackNum = value; }
        }

        //method
        public void AddTrack(Song newSong)
        {
            if (trackNum < track.Length)
            {
                track[trackNum] = newSong;
                trackNum++;
            }
        }

        public void Display()
        {
            for (int i = 0; i < trackNum; i++)
            {
                track[i].Display();
            }
        }
    }
}
