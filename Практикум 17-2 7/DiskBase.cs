using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace Практикум_17_2_7
{
    [Serializable]
    public class DiskBase
    {
        private uint index;
        private Hashtable Disks;

        public DiskBase()
        {
            Disks = new Hashtable();
            index = 1;
        }

        public void ShowAllDisksEntirely()
        {
            ICollection keys = Disks.Keys;
            foreach (uint index in keys)
            {
                Disk item = (Disk)Disks[index];
                Console.WriteLine("№{0}",index); 
                item.Show();
            }
        }

        public List<Song> GetAllDisksEntirely()
        {
            var res = new List<Song>();
            ICollection keys = Disks.Keys;
            foreach (uint index in keys)
            {
                Disk item = (Disk)Disks[index];
                res.AddRange(item.GetSongs());
            }
            return res;
        }


        public void ShowAllDisksTitles()
        {
            ICollection keys = Disks.Keys;
            foreach (uint index in keys)
            {
                Disk item = (Disk)Disks[index];
                Console.WriteLine("#{0}",index); 
                item.ShowDiskName();
            }
        }

        public List<string> GetDisksTitles()
        {
            var res = new List<string>();
            ICollection keys = Disks.Keys;
            foreach (uint index in keys)
            {
                Disk item = (Disk)Disks[index];
                string title = "#"+ index + "\t"+ item.GetDiskName();
                res.Add(title);
            }
            return res;
        }

        public void DeleteDisk(uint index)
        {
            Disks.Remove(index);
        }
        
        public void AddDisk(Disk disk)
        {
            Disks.Add(index,disk);
            index++;
        }

        public void RemoveSong(uint indexOfDisk, uint index)
        {
            Disk disk = (Disk) Disks[indexOfDisk];
            disk.DeleteSong(index);
        }

        public void ShowDisk(uint index)
        {
            Disk disk = (Disk) Disks[index];
            disk.Show();
        }

        public List<Song> GetDisk(uint index)
        {
            Disk disk = (Disk)Disks[index];
            return disk.GetSongs();
        }
        
        public void AddSongToDisk(uint index, Song song)
        {
            Disk disk = (Disk)Disks[index];
            disk.AddSong(song);
        }

        public void AddSongToDisk(uint index, string name, string author)
        {
            Disk disk = (Disk) Disks[index];
            disk.AddSong(new Song(name, author));
        }

        public List<Song> SearchForSuthor(string author)
        {
            var result = new List<Song>();
            ICollection keys = Disks.Keys;
            foreach (uint index in keys)
            {
                Disk item = (Disk)Disks[index];
                result.AddRange(item.SearchSongsByAuthor(author));
            }
            return result;
        }

        public void SortByAutor()
        {
            ICollection keys = Disks.Keys;
            foreach (uint index in keys)
            {
                Disk item = (Disk)Disks[index];
                item.SortSongsByAuthor();
            }
        }
        
        public void SortByNames()
        {
            ICollection keys = Disks.Keys;
            foreach (uint index in keys)
            {
                Disk item = (Disk)Disks[index];
                item.SortSongsByNames();
            }
        }

        public DiskBase GetBase() {
            return this;
        }
        
        
    }
}