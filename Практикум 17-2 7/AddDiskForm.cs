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
    public partial class AddDiskForm : Form
    {
        public AddDiskForm()
        {
            InitializeComponent();
        }

        private void AddDiskForm_Load(object sender, EventArgs e)
        {
            this.AddDiskTxtBox.Focus();
        }

        private void AddDiskBtn_Click(object sender, EventArgs e)
        {
            if (AddDiskTxtBox.Text == "")
            {
                MessageBox.Show("Enter the Disk Name");
                return;
            }
            this.Close();
        }
        
        public string GetNameOfDiskToAdd()
        {
            return AddDiskTxtBox.Text;
        }
    }
}
