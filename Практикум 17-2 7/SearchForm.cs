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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            this.SearchTxtBox.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(SearchTxtBox.Text == "")
            {
                MessageBox.Show("Enter the Name of Author!");
                return;
            }
            this.Close();
        }

        public string GetNameOfAuthor()
        {
            return SearchTxtBox.Text;
        }
    }
}
