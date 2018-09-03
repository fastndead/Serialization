using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Практикум_17_2_7
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DiskListRefresh();
        }
        private uint diskIndex;

        private void DiskListRefresh()
        {
            DiskListBox.Items.Clear();
            var DisksTitlesList = Program.MainBase.GetDisksTitles();
            DisksTitlesList.Sort();

            foreach (var item in DisksTitlesList)
            {
                DiskListBox.Items.Add(item);
            }
        }
        public void SongListBoxRefresh()
        {
            SongListBox.Items.Clear();
            var SongsList = Program.MainBase.GetDisk(diskIndex);
            foreach (var item in SongsList)
            {
                SongListBox.Items.Add(item.ToString());
            }
        }

        public void SongListBoxRefresh(List<Song> s)
        {
            SongListBox.Items.Clear();
            foreach (var item in s)
            {
                SongListBox.Items.Add(item.ToString());
            }
        }

        private void DiskListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            diskIndex = uint.Parse(DiskListBox.SelectedItem.ToString()[1].ToString());
            SongListBoxRefresh(Program.MainBase.GetDisk(diskIndex));

        }

        private void AddSongBtn_Click(object sender, EventArgs e)
        {
            AddSongForm addSongForm = new AddSongForm();
            
            addSongForm.FormClosing += new FormClosingEventHandler(AddSongForm_FormClosing);
            addSongForm.ShowDialog();
        }

        void AddSongForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.MainBase.AddSongToDisk(diskIndex, new Song((sender as AddSongForm).GetName(), (sender as AddSongForm).GetAuthor()));
            SongListBoxRefresh();
        }

        private void DeleteSong_Click(object sender, EventArgs e)
        {
            if (SongListBox.SelectedIndex >= 0)
            {
                Program.MainBase.RemoveSong((uint)DiskListBox.SelectedIndex + 1, (uint)SongListBox.SelectedIndex);
                SongListBoxRefresh();
            }
        }

        private void SortByAuthorBtn_Click(object sender, EventArgs e)
        {
            Program.MainBase.SortByAutor();
            SongListBoxRefresh();
        }

        private void SortByNamesBtn_Click(object sender, EventArgs e)
        {
            Program.MainBase.SortByNames();
            SongListBoxRefresh();
        }

        private void DeleteDiskBtn_Click(object sender, EventArgs e)
        {
            Program.MainBase.DeleteDisk(diskIndex);
            SongListBox.Items.Clear();
            DiskListRefresh();
        }

        private void ShowWholeLibraryBtn_Click(object sender, EventArgs e)
        {
            SongListBox.Items.Clear();
            foreach (var item in Program.MainBase.GetAllDisksEntirely())
            {
                SongListBox.Items.Add(item.ToString());
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchForm f = new SearchForm();
            f.FormClosing += new FormClosingEventHandler(SearchForm_FlormClosing);
            f.ShowDialog();
        }

        private void SearchForm_FlormClosing(object sender, FormClosingEventArgs e)
        {
            SongListBoxRefresh(Program.MainBase.SearchForSuthor((sender as SearchForm).GetNameOfAuthor()));
        }

        private void AddDiskBtn_Click(object sender, EventArgs e)
        {
            AddDiskForm f = new AddDiskForm();
            f.FormClosing += new FormClosingEventHandler(AddDiskForm_FormCLosing);
            f.ShowDialog();
        }

        private void AddDiskForm_FormCLosing(object sender, FormClosingEventArgs e)
        {
            Program.MainBase.AddDisk(new Disk((sender as AddDiskForm).GetNameOfDiskToAdd()));
            DiskListRefresh();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            using (var fs = new FileStream("C:/Users/umbetovaa/Downloads/Практикум 17-2 7/disks.dat", FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, Program.MainBase.GetBase());
            }
                
        }
    }
}