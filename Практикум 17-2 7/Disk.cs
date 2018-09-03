using System;
using System.Collections.Generic;

namespace Практикум_17_2_7
{
    [Serializable]
    public class Disk
    {
        private string DiskName;
        private List<Song> Songs= new List<Song>();
        
        public Disk(string name)
        {
            DiskName = name;
        }

        public Disk(string name, params Song[] songs):this(name)
        {
            foreach (var song in songs)
            {
                Songs.Add(song);
            }
        }
        
        public List<Song> SearchSongsByAuthor(string author)
        {
            List<Song> FoundSongs= new List<Song>();
            foreach (var song in Songs)
            {
                if (song.GetSongAutor().ToLower() == author.ToLower())
                {
                    Song temp = song;
                    FoundSongs.Add(temp);
                }
            }
            return FoundSongs;
        }
        public List<Song> GetSongs()
        {
            List<Song> res = new List<Song>();
            res.AddRange(Songs);
            return res;
        }

        public void DeleteSong(uint index)
        {
            Songs.RemoveAt((int)index);    
        }
        
        public void AddSong(Song song)
        {
            Songs.Add(song);
        }
        
        public void Show()
        {
            Console.Write("Disk Name: {0}\nTracklist:\n", DiskName);
            int k = 1;
            foreach (var song in Songs)
            {
                Console.Write("{0}. ",k); k++;
                song.Show();
            }
            Console.WriteLine();
        }

        public void SortSongsByNames()
        {
            Songs.Sort(new CompBySongName());
        }
        
        public void SortSongsByAuthor()
        {
            Songs.Sort(new CompBySongAuthor());
        }
        
        public void ShowDiskName()
        {
            Console.WriteLine(DiskName);
        }

        public string GetDiskName()
        {
            return DiskName;
        }
    }

    public class CompBySongName : IComparer<Song>
    {
        public int Compare(Song x, Song y)
        {
            return x.GetSongName().CompareTo(y.GetSongName());
        }
    }
    
    public class CompBySongAuthor : IComparer<Song>
    {
        public int Compare(Song x, Song y)
        {
            return x.GetSongAutor().CompareTo(y.GetSongAutor());
        }
    }
}