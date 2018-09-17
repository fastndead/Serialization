using System;
using System.Globalization;

namespace Практикум_17_2_7
{
    [Serializable]
    public class Song
    {
        public string SongName;
        public string SongAuthor;

        public Song(string name, string author)
        {
            SongName = name;
            SongAuthor = author;
        }

        public Song() {
            SongName = "NoName";
            SongAuthor = "NoName";
        }

        public string GetSongAutor()
        {
            return this.SongAuthor;
        }

        public string GetSongName()
        {
            return this.SongName;
        }

        public override string ToString()
        {
            string res = SongAuthor + " - " + SongName;
            return res;
        }

        public void Show()
        {
            Console.WriteLine(SongAuthor +" - "+ SongName); 
        }
    }
}