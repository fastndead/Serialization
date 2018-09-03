namespace Практикум_17_2_7
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DiskListBox = new System.Windows.Forms.ListBox();
            this.SongListBox = new System.Windows.Forms.ListBox();
            this.AddSongBtn = new System.Windows.Forms.Button();
            this.DeleteSong = new System.Windows.Forms.Button();
            this.SortByAuthorBtn = new System.Windows.Forms.Button();
            this.SortByNamesBtn = new System.Windows.Forms.Button();
            this.DeleteDiskBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.AddDiskBtn = new System.Windows.Forms.Button();
            this.ShowWholeLibraryBtn = new System.Windows.Forms.Button();
            this.SongGroupBox = new System.Windows.Forms.GroupBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.SongGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DiskListBox
            // 
            this.DiskListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DiskListBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiskListBox.FormattingEnabled = true;
            this.DiskListBox.HorizontalScrollbar = true;
            this.DiskListBox.ItemHeight = 18;
            this.DiskListBox.Location = new System.Drawing.Point(20, 58);
            this.DiskListBox.Name = "DiskListBox";
            this.DiskListBox.Size = new System.Drawing.Size(318, 434);
            this.DiskListBox.TabIndex = 0;
            this.DiskListBox.SelectedIndexChanged += new System.EventHandler(this.DiskListBox_SelectedIndexChanged);
            // 
            // SongListBox
            // 
            this.SongListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SongListBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SongListBox.FormattingEnabled = true;
            this.SongListBox.HorizontalScrollbar = true;
            this.SongListBox.ItemHeight = 18;
            this.SongListBox.Location = new System.Drawing.Point(11, 45);
            this.SongListBox.Name = "SongListBox";
            this.SongListBox.Size = new System.Drawing.Size(318, 342);
            this.SongListBox.TabIndex = 1;
            // 
            // AddSongBtn
            // 
            this.AddSongBtn.Location = new System.Drawing.Point(11, 422);
            this.AddSongBtn.Name = "AddSongBtn";
            this.AddSongBtn.Size = new System.Drawing.Size(75, 39);
            this.AddSongBtn.TabIndex = 2;
            this.AddSongBtn.Text = "Add";
            this.AddSongBtn.UseVisualStyleBackColor = true;
            this.AddSongBtn.Click += new System.EventHandler(this.AddSongBtn_Click);
            // 
            // DeleteSong
            // 
            this.DeleteSong.Location = new System.Drawing.Point(92, 422);
            this.DeleteSong.Name = "DeleteSong";
            this.DeleteSong.Size = new System.Drawing.Size(75, 39);
            this.DeleteSong.TabIndex = 3;
            this.DeleteSong.Text = "Delete";
            this.DeleteSong.UseVisualStyleBackColor = true;
            this.DeleteSong.Click += new System.EventHandler(this.DeleteSong_Click);
            // 
            // SortByAuthorBtn
            // 
            this.SortByAuthorBtn.Location = new System.Drawing.Point(173, 422);
            this.SortByAuthorBtn.Name = "SortByAuthorBtn";
            this.SortByAuthorBtn.Size = new System.Drawing.Size(75, 39);
            this.SortByAuthorBtn.TabIndex = 4;
            this.SortByAuthorBtn.Text = "Sort by Author";
            this.SortByAuthorBtn.UseVisualStyleBackColor = true;
            this.SortByAuthorBtn.Click += new System.EventHandler(this.SortByAuthorBtn_Click);
            // 
            // SortByNamesBtn
            // 
            this.SortByNamesBtn.Location = new System.Drawing.Point(254, 422);
            this.SortByNamesBtn.Name = "SortByNamesBtn";
            this.SortByNamesBtn.Size = new System.Drawing.Size(75, 39);
            this.SortByNamesBtn.TabIndex = 5;
            this.SortByNamesBtn.Text = "Sort by Name";
            this.SortByNamesBtn.UseVisualStyleBackColor = true;
            this.SortByNamesBtn.Click += new System.EventHandler(this.SortByNamesBtn_Click);
            // 
            // DeleteDiskBtn
            // 
            this.DeleteDiskBtn.Location = new System.Drawing.Point(263, 19);
            this.DeleteDiskBtn.Name = "DeleteDiskBtn";
            this.DeleteDiskBtn.Size = new System.Drawing.Size(75, 33);
            this.DeleteDiskBtn.TabIndex = 6;
            this.DeleteDiskBtn.Text = "Delete ";
            this.DeleteDiskBtn.UseVisualStyleBackColor = true;
            this.DeleteDiskBtn.Click += new System.EventHandler(this.DeleteDiskBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(20, 19);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 33);
            this.SearchBtn.TabIndex = 7;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // AddDiskBtn
            // 
            this.AddDiskBtn.Location = new System.Drawing.Point(101, 19);
            this.AddDiskBtn.Name = "AddDiskBtn";
            this.AddDiskBtn.Size = new System.Drawing.Size(75, 33);
            this.AddDiskBtn.TabIndex = 8;
            this.AddDiskBtn.Text = "Add Disk";
            this.AddDiskBtn.UseVisualStyleBackColor = true;
            this.AddDiskBtn.Click += new System.EventHandler(this.AddDiskBtn_Click);
            // 
            // ShowWholeLibraryBtn
            // 
            this.ShowWholeLibraryBtn.Location = new System.Drawing.Point(182, 19);
            this.ShowWholeLibraryBtn.Name = "ShowWholeLibraryBtn";
            this.ShowWholeLibraryBtn.Size = new System.Drawing.Size(75, 33);
            this.ShowWholeLibraryBtn.TabIndex = 9;
            this.ShowWholeLibraryBtn.Text = "Show All";
            this.ShowWholeLibraryBtn.UseVisualStyleBackColor = true;
            this.ShowWholeLibraryBtn.Click += new System.EventHandler(this.ShowWholeLibraryBtn_Click);
            // 
            // SongGroupBox
            // 
            this.SongGroupBox.Controls.Add(this.SortByNamesBtn);
            this.SongGroupBox.Controls.Add(this.SortByAuthorBtn);
            this.SongGroupBox.Controls.Add(this.DeleteSong);
            this.SongGroupBox.Controls.Add(this.AddSongBtn);
            this.SongGroupBox.Controls.Add(this.SongListBox);
            this.SongGroupBox.Location = new System.Drawing.Point(369, 31);
            this.SongGroupBox.Name = "SongGroupBox";
            this.SongGroupBox.Size = new System.Drawing.Size(344, 481);
            this.SongGroupBox.TabIndex = 10;
            this.SongGroupBox.TabStop = false;
            this.SongGroupBox.Text = "Songs";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(638, 12);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 11;
            this.SaveBtn.Text = "SAVE";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(734, 531);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.SongGroupBox);
            this.Controls.Add(this.ShowWholeLibraryBtn);
            this.Controls.Add(this.AddDiskBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.DeleteDiskBtn);
            this.Controls.Add(this.DiskListBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(750, 569);
            this.MinimumSize = new System.Drawing.Size(750, 569);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.SongGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox DiskListBox;
        private System.Windows.Forms.ListBox SongListBox;
        private System.Windows.Forms.Button AddSongBtn;
        private System.Windows.Forms.Button DeleteSong;
        private System.Windows.Forms.Button SortByAuthorBtn;
        private System.Windows.Forms.Button SortByNamesBtn;
        private System.Windows.Forms.Button DeleteDiskBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button AddDiskBtn;
        private System.Windows.Forms.Button ShowWholeLibraryBtn;
        private System.Windows.Forms.GroupBox SongGroupBox;
        private System.Windows.Forms.Button SaveBtn;
    }
}