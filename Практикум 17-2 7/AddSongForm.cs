using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практикум_17_2_7
{
    public partial class AddSongForm : Form
    {
        public AddSongForm()
        {
            InitializeComponent();
        }

        private void ProceedAddSongBtn_Click(object sender, EventArgs e)
        {
            if (AddSongNameTxtBox.Text == "" && AddSongAuthorTxtBox.Text == "")
            {
                MessageBox.Show("Enter the Author and the Name of Song !");
                return;
            }
            else if (AddSongAuthorTxtBox.Text == "")
            {
                MessageBox.Show("Enter the Name of Author!");
                return;
            }
            else if (AddSongNameTxtBox.Text == "")
            {
                MessageBox.Show("Enter the Name of Song!");
                return;
            }
                this.Close();
        }
        
        public string GetAuthor()
        {
            return AddSongAuthorTxtBox.Text;
        }

        public string GetName()
        {
            return AddSongNameTxtBox.Text;
        }

    }
}
