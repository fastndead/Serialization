using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Services;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Практикум_17_2_7
{
    internal class Program
    {
        public static DiskBase MainBase = new DiskBase();

        public static void Main(string[] args)
        {
             /*var input = new StreamReader("input.txt");
             while (input.Peek() != -1)
             {
                 string temp = input.ReadLine();
                 if (temp.Trim() == "\n")
                     continue;
                 if (temp.Trim() == "DISK")
                 {
                     string nameDisk = input.ReadLine();
                     Disk DiskInput = new Disk(nameDisk);
                     if (input.ReadLine().Trim() == "SONGS")
                     {
                         int k = int.Parse(input.ReadLine().Trim());
                         for (int i = 0; i < k; i++)
                         {
                             string[] song = input.ReadLine().Split('-');
                             Song SongInput = new Song(song[1].Trim(), song[0].Trim());
                             DiskInput.AddSong(SongInput);
                         }
                     }

                     MainBase.AddDisk(DiskInput);
                 }
             }*/
           using (var fs = new FileStream("C:/Users/umbetovaa/Downloads/Практикум 17-2 7/disks.xml", FileMode.OpenOrCreate))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(DiskBase));
                MainBase = (DiskBase)formatter.Deserialize(fs);
            }
                

            Presentation();

        }

        public static void Presentation()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            ////PRESENTATION
            //bool WhileLoopWork = true;
            //Console.WriteLine("List of Disks:");
            //MainBase.ShowAllDisksTitles();

            //while (WhileLoopWork)
            //{
            //    Console.WriteLine("\nChoose What to Do?:");
            //    Console.WriteLine("1 - Show Disk");
            //    Console.WriteLine("2 - Add Song");
            //    Console.WriteLine("3 - Search for an Author");
            //    Console.WriteLine("4 - Show Whole Library");
            //    Console.WriteLine("5 - Delete Song");
            //    Console.WriteLine("6 - Delete Disk");
            //    Console.WriteLine("7 - Sort Songs by Author");
            //    Console.WriteLine("8 - Sort Songs by Names");

            //    string inputValue = Console.ReadLine();

            //    if (inputValue == "1") //Show Disk
            //    {
            //        Console.Write("Enter Disk Number: ");
            //        uint index = uint.Parse(Console.ReadLine());
            //        MainBase.ShowDisk(index);
            //    }
            //    else if (inputValue == "2") //AddSong
            //    {
            //        Console.Write("Type Author of the song:");
            //        string author = Console.ReadLine();
            //        Console.Write("Type Song Name:");
            //        string name = Console.ReadLine();
            //        Console.Write("Enter Disk Number: ");
            //        uint index = uint.Parse(Console.ReadLine());
            //        MainBase.AddSongToDisk(index, new Song(name, author));
            //    }
            //    else if (inputValue == "3") //Search For an Author
            //    {
            //        Console.Write("Type the Author name: ");
            //        string author = Console.ReadLine();
            //        MainBase.SearchForSuthor(author);
            //    }
            //    else if (inputValue == "4") //Show Whole Library
            //    {
            //        MainBase.ShowAllDisksEntirely();
            //    }
            //    else if (inputValue == "5") //Delete Song
            //    {
            //        Console.Write("Type the Disk Number: ");
            //        uint DiskIndex = uint.Parse(Console.ReadLine());
            //        Console.WriteLine("Type the Song Number");
            //        uint index = uint.Parse(Console.ReadLine());
            //        MainBase.RemoveSong(DiskIndex, index);
            //    }
            //    else if (inputValue == "6") //Delete Disk
            //    {
            //        Console.Write("Type the Disk Number: ");
            //        uint DiskIndex = uint.Parse(Console.ReadLine());
            //        MainBase.DeleteDisk(DiskIndex);
            //    }
            //    else if (inputValue == "7") //Sort By Autor
            //    {
            //        MainBase.SortByAutor();
            //    }
            //    else if (inputValue == "8")
            //    {
            //        MainBase.SortByNames();
            //    }
            //    else if (inputValue == "0")
            //    {
            //        Console.WriteLine("Goodbye!");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("You've typed invalid number!");
            //    }
            //}


        }
    }
}