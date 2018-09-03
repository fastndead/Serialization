namespace Практикум_17_2_7
{
    partial class AddDiskForm
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
            this.AddDiskTxtBox = new System.Windows.Forms.TextBox();
            this.AddDiskBtn = new System.Windows.Forms.Button();
            this.AddDiskLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddDiskTxtBox
            // 
            this.AddDiskTxtBox.Location = new System.Drawing.Point(12, 62);
            this.AddDiskTxtBox.Name = "AddDiskTxtBox";
            this.AddDiskTxtBox.Size = new System.Drawing.Size(369, 20);
            this.AddDiskTxtBox.TabIndex = 5;
            // 
            // AddDiskBtn
            // 
            this.AddDiskBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddDiskBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDiskBtn.Location = new System.Drawing.Point(0, 107);
            this.AddDiskBtn.Name = "AddDiskBtn";
            this.AddDiskBtn.Size = new System.Drawing.Size(390, 43);
            this.AddDiskBtn.TabIndex = 4;
            this.AddDiskBtn.Text = "Add Disk";
            this.AddDiskBtn.UseVisualStyleBackColor = true;
            this.AddDiskBtn.Click += new System.EventHandler(this.AddDiskBtn_Click);
            // 
            // AddDiskLabel
            // 
            this.AddDiskLabel.AutoSize = true;
            this.AddDiskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDiskLabel.Location = new System.Drawing.Point(12, 39);
            this.AddDiskLabel.Name = "AddDiskLabel";
            this.AddDiskLabel.Size = new System.Drawing.Size(202, 20);
            this.AddDiskLabel.TabIndex = 3;
            this.AddDiskLabel.Text = "Enter Name of Disk to Add:";
            // 
            // AddDiskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 150);
            this.Controls.Add(this.AddDiskTxtBox);
            this.Controls.Add(this.AddDiskBtn);
            this.Controls.Add(this.AddDiskLabel);
            this.Name = "AddDiskForm";
            this.Text = "AddDiskForm";
            this.Load += new System.EventHandler(this.AddDiskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddDiskTxtBox;
        private System.Windows.Forms.Button AddDiskBtn;
        private System.Windows.Forms.Label AddDiskLabel;
    }
}