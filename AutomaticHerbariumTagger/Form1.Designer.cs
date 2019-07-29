namespace AutomaticHerbariumTagger
{
    partial class Form1
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnFolderPicker = new System.Windows.Forms.Button();
            this.labelFolderPath = new System.Windows.Forms.Label();
            this.textBoxFolderPath = new System.Windows.Forms.TextBox();
            this.buttonCSVPicker = new System.Windows.Forms.Button();
            this.textBoxCSVPath = new System.Windows.Forms.TextBox();
            this.buttonTagImages = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelTitle.Location = new System.Drawing.Point(139, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(277, 24);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Digital Herbarium Image Tagger";
            // 
            // btnFolderPicker
            // 
            this.btnFolderPicker.Location = new System.Drawing.Point(25, 81);
            this.btnFolderPicker.Name = "btnFolderPicker";
            this.btnFolderPicker.Size = new System.Drawing.Size(140, 20);
            this.btnFolderPicker.TabIndex = 1;
            this.btnFolderPicker.Text = "Select a Folder";
            this.btnFolderPicker.UseVisualStyleBackColor = true;
            this.btnFolderPicker.Click += new System.EventHandler(this.BtnFolderPicker_Click);
            // 
            // labelFolderPath
            // 
            this.labelFolderPath.AutoSize = true;
            this.labelFolderPath.Location = new System.Drawing.Point(171, 84);
            this.labelFolderPath.Name = "labelFolderPath";
            this.labelFolderPath.Size = new System.Drawing.Size(0, 13);
            this.labelFolderPath.TabIndex = 2;
            // 
            // textBoxFolderPath
            // 
            this.textBoxFolderPath.Enabled = false;
            this.textBoxFolderPath.Location = new System.Drawing.Point(171, 81);
            this.textBoxFolderPath.Name = "textBoxFolderPath";
            this.textBoxFolderPath.Size = new System.Drawing.Size(339, 20);
            this.textBoxFolderPath.TabIndex = 3;
            // 
            // buttonCSVPicker
            // 
            this.buttonCSVPicker.Location = new System.Drawing.Point(25, 137);
            this.buttonCSVPicker.Name = "buttonCSVPicker";
            this.buttonCSVPicker.Size = new System.Drawing.Size(140, 20);
            this.buttonCSVPicker.TabIndex = 4;
            this.buttonCSVPicker.Text = "Select a CSV File";
            this.buttonCSVPicker.UseVisualStyleBackColor = true;
            this.buttonCSVPicker.Click += new System.EventHandler(this.ButtonCSVPicker_Click);
            // 
            // textBoxCSVPath
            // 
            this.textBoxCSVPath.Enabled = false;
            this.textBoxCSVPath.Location = new System.Drawing.Point(171, 137);
            this.textBoxCSVPath.Name = "textBoxCSVPath";
            this.textBoxCSVPath.Size = new System.Drawing.Size(339, 20);
            this.textBoxCSVPath.TabIndex = 5;
            // 
            // buttonTagImages
            // 
            this.buttonTagImages.Location = new System.Drawing.Point(25, 196);
            this.buttonTagImages.Name = "buttonTagImages";
            this.buttonTagImages.Size = new System.Drawing.Size(485, 23);
            this.buttonTagImages.TabIndex = 6;
            this.buttonTagImages.Text = "Start Tagging";
            this.buttonTagImages.UseVisualStyleBackColor = true;
            this.buttonTagImages.Click += new System.EventHandler(this.ButtonTagImages_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(22, 243);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(43, 13);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Status: ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(275, 295);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(258, 13);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Created By Curtis Neely - curtisneely65@outlook.com";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(545, 317);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonTagImages);
            this.Controls.Add(this.textBoxCSVPath);
            this.Controls.Add(this.buttonCSVPicker);
            this.Controls.Add(this.textBoxFolderPath);
            this.Controls.Add(this.labelFolderPath);
            this.Controls.Add(this.btnFolderPicker);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.Text = "Lets Tag!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnFolderPicker;
        private System.Windows.Forms.Label labelFolderPath;
        private System.Windows.Forms.TextBox textBoxFolderPath;
        private System.Windows.Forms.Button buttonCSVPicker;
        private System.Windows.Forms.TextBox textBoxCSVPath;
        private System.Windows.Forms.Button buttonTagImages;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelName;
    }
}

