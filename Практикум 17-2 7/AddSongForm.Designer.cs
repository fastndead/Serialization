namespace Практикум_17_2_7
{
    partial class AddSongForm
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
            this.AddSongNameTxtBox = new System.Windows.Forms.TextBox();
            this.AddSongAuthorTxtBox = new System.Windows.Forms.TextBox();
            this.Author = new System.Windows.Forms.Label();
            this.SongName = new System.Windows.Forms.Label();
            this.ProceedAddSongBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddSongNameTxtBox
            // 
            this.AddSongNameTxtBox.Location = new System.Drawing.Point(48, 106);
            this.AddSongNameTxtBox.Name = "AddSongNameTxtBox";
            this.AddSongNameTxtBox.Size = new System.Drawing.Size(206, 20);
            this.AddSongNameTxtBox.TabIndex = 0;
            // 
            // AddSongAuthorTxtBox
            // 
            this.AddSongAuthorTxtBox.Location = new System.Drawing.Point(47, 47);
            this.AddSongAuthorTxtBox.Name = "AddSongAuthorTxtBox";
            this.AddSongAuthorTxtBox.Size = new System.Drawing.Size(207, 20);
            this.AddSongAuthorTxtBox.TabIndex = 1;
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Author.Location = new System.Drawing.Point(44, 21);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(74, 23);
            this.Author.TabIndex = 2;
            this.Author.Text = "Author";
            // 
            // SongName
            // 
            this.SongName.AutoSize = true;
            this.SongName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SongName.Location = new System.Drawing.Point(44, 80);
            this.SongName.Name = "SongName";
            this.SongName.Size = new System.Drawing.Size(120, 23);
            this.SongName.TabIndex = 3;
            this.SongName.Text = "Song Name";
            // 
            // ProceedAddSongBtn
            // 
            this.ProceedAddSongBtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProceedAddSongBtn.Location = new System.Drawing.Point(48, 158);
            this.ProceedAddSongBtn.Name = "ProceedAddSongBtn";
            this.ProceedAddSongBtn.Size = new System.Drawing.Size(206, 35);
            this.ProceedAddSongBtn.TabIndex = 4;
            this.ProceedAddSongBtn.Text = "Add Song";
            this.ProceedAddSongBtn.UseVisualStyleBackColor = true;
            this.ProceedAddSongBtn.Click += new System.EventHandler(this.ProceedAddSongBtn_Click);
            // 
            // AddSongForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(300, 215);
            this.Controls.Add(this.ProceedAddSongBtn);
            this.Controls.Add(this.SongName);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.AddSongAuthorTxtBox);
            this.Controls.Add(this.AddSongNameTxtBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(316, 254);
            this.MinimumSize = new System.Drawing.Size(316, 254);
            this.Name = "AddSongForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Add Song";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddSongNameTxtBox;
        private System.Windows.Forms.TextBox AddSongAuthorTxtBox;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label SongName;
        private System.Windows.Forms.Button ProceedAddSongBtn;
    }
}