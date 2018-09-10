using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace Практикум_17_2_7
{
    [Serializable]
    public class DiskBase
    {
        public uint index;
        public List<Disk> Disks;

        public DiskBase()
        {
            Disks = new List<Disk>();
            index = 1;
        }

        public List<Song> GetAllDisksEntirely()
        {
            var res = new List<Song>();
            foreach (Disk item in Disks)
            { 
                res.AddRange(item.GetSongs());
            }
            return res;
        }


        public List<string> GetDisksTitles()
        {
            var res = new List<string>();
            foreach (Disk item in Disks)
            {
                string title = "#"+ item.GetHashCode() + "\t"+ item.GetDiskName();
                res.Add(title);
            }
            return res;
        }

        public void DeleteDisk(uint index)
        {
            Disks.RemoveAt((int)index);
        }
        
        public void AddDisk(Disk disk)
        {
            Disks.Add(disk);
            index++;
        }

        public void RemoveSong(uint indexOfDisk, uint index)
        {
            Disk disk = Disks[(int)indexOfDisk];
            disk.DeleteSong(index);
        }

        public void ShowDisk(uint index)
        {
            Disk disk = (Disk) Disks[(int)index];
            disk.Show();
        }

        public List<Song> GetDisk(uint index)
        {
            Disk disk = (Disk)Disks[(int)index];
            return disk.GetSongs();
        }
        
        public void AddSongToDisk(uint index, Song song)
        {
            Disk disk = (Disk)Disks[(int)index];
            disk.AddSong(song);
        }

        public void AddSongToDisk(uint index, string name, string author)
        {
            Disk disk = (Disk) Disks[(int)index];
            disk.AddSong(new Song(name, author));
        }

        public List<Song> SearchForSuthor(string author)
        {
            var result = new List<Song>();
            foreach (Disk item in Disks)
            {
                result.AddRange(item.SearchSongsByAuthor(author));
            }
            return result;
        }

        public void SortByAutor()
        {
            foreach (Disk item in Disks)
            { 
                item.SortSongsByAuthor();
            }
        }
        
        public void SortByNames()
        {
            foreach (Disk item in Disks)
            {
                item.SortSongsByNames();
            }
        }

        public DiskBase GetBase() {
            return this;
        }
        
        
    }
}