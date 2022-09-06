namespace Pandemonium_Classic___Mod_Manager
{
    partial class PCUE_ModManager
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
            this.modListBox = new System.Windows.Forms.ListBox();
            this.modThumbnailBox = new System.Windows.Forms.PictureBox();
            this.modDescriptionBox = new System.Windows.Forms.TextBox();
            this.modFolderFileBrowser = new System.Windows.Forms.Button();
            this.modFolderInputBox = new System.Windows.Forms.TextBox();
            this.gameFolderFileBrowser = new System.Windows.Forms.Button();
            this.gameDataFolderInputBox = new System.Windows.Forms.TextBox();
            this.installButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.modThumbnailBox)).BeginInit();
            this.SuspendLayout();
            // 
            // modListBox
            // 
            this.modListBox.FormattingEnabled = true;
            this.modListBox.ItemHeight = 15;
            this.modListBox.Location = new System.Drawing.Point(287, 6);
            this.modListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modListBox.Name = "modListBox";
            this.modListBox.Size = new System.Drawing.Size(174, 214);
            this.modListBox.TabIndex = 8;
            this.modListBox.SelectedIndexChanged += new System.EventHandler(this.modListBox_SelectedIndexChanged);
            // 
            // modThumbnailBox
            // 
            this.modThumbnailBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.modThumbnailBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.modThumbnailBox.Location = new System.Drawing.Point(138, 6);
            this.modThumbnailBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modThumbnailBox.Name = "modThumbnailBox";
            this.modThumbnailBox.Size = new System.Drawing.Size(148, 127);
            this.modThumbnailBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.modThumbnailBox.TabIndex = 9;
            this.modThumbnailBox.TabStop = false;
            this.modThumbnailBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // modDescriptionBox
            // 
            this.modDescriptionBox.Location = new System.Drawing.Point(2, 6);
            this.modDescriptionBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modDescriptionBox.Multiline = true;
            this.modDescriptionBox.Name = "modDescriptionBox";
            this.modDescriptionBox.PlaceholderText = "Mod Description";
            this.modDescriptionBox.ReadOnly = true;
            this.modDescriptionBox.Size = new System.Drawing.Size(129, 127);
            this.modDescriptionBox.TabIndex = 11;
            // 
            // modFolderFileBrowser
            // 
            this.modFolderFileBrowser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.modFolderFileBrowser.Location = new System.Drawing.Point(194, 176);
            this.modFolderFileBrowser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modFolderFileBrowser.Name = "modFolderFileBrowser";
            this.modFolderFileBrowser.Size = new System.Drawing.Size(15, 12);
            this.modFolderFileBrowser.TabIndex = 18;
            this.modFolderFileBrowser.Text = "...";
            this.modFolderFileBrowser.UseVisualStyleBackColor = true;
            this.modFolderFileBrowser.Click += new System.EventHandler(this.modFolderFileBrowser_Click);
            // 
            // modFolderInputBox
            // 
            this.modFolderInputBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.modFolderInputBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.modFolderInputBox.Location = new System.Drawing.Point(5, 165);
            this.modFolderInputBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modFolderInputBox.Name = "modFolderInputBox";
            this.modFolderInputBox.PlaceholderText = "Mod Folder";
            this.modFolderInputBox.Size = new System.Drawing.Size(185, 23);
            this.modFolderInputBox.TabIndex = 17;
            this.modFolderInputBox.TextChanged += new System.EventHandler(this.modFolderInputBox_TextChanged);
            // 
            // gameFolderFileBrowser
            // 
            this.gameFolderFileBrowser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gameFolderFileBrowser.Location = new System.Drawing.Point(193, 202);
            this.gameFolderFileBrowser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gameFolderFileBrowser.Name = "gameFolderFileBrowser";
            this.gameFolderFileBrowser.Size = new System.Drawing.Size(15, 12);
            this.gameFolderFileBrowser.TabIndex = 16;
            this.gameFolderFileBrowser.Text = "...";
            this.gameFolderFileBrowser.UseVisualStyleBackColor = true;
            this.gameFolderFileBrowser.Click += new System.EventHandler(this.button1_Click);
            // 
            // gameDataFolderInputBox
            // 
            this.gameDataFolderInputBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.gameDataFolderInputBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.gameDataFolderInputBox.Location = new System.Drawing.Point(5, 192);
            this.gameDataFolderInputBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gameDataFolderInputBox.Name = "gameDataFolderInputBox";
            this.gameDataFolderInputBox.PlaceholderText = "Game Data Folder";
            this.gameDataFolderInputBox.Size = new System.Drawing.Size(185, 23);
            this.gameDataFolderInputBox.TabIndex = 15;
            this.gameDataFolderInputBox.TextChanged += new System.EventHandler(this.gameDataFolderInputBox_TextChanged);
            // 
            // installButton
            // 
            this.installButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.installButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.installButton.Location = new System.Drawing.Point(212, 183);
            this.installButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(72, 33);
            this.installButton.TabIndex = 13;
            this.installButton.Text = "Install";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // PCUE_ModManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 225);
            this.Controls.Add(this.modFolderFileBrowser);
            this.Controls.Add(this.modFolderInputBox);
            this.Controls.Add(this.gameFolderFileBrowser);
            this.Controls.Add(this.gameDataFolderInputBox);
            this.Controls.Add(this.installButton);
            this.Controls.Add(this.modDescriptionBox);
            this.Controls.Add(this.modThumbnailBox);
            this.Controls.Add(this.modListBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PCUE_ModManager";
            this.Text = "Pandemonium Classic - Mod Manager Version 1.0.0";
            ((System.ComponentModel.ISupportInitialize)(this.modThumbnailBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox modListBox;
        private PictureBox modThumbnailBox;
        private TextBox modDescriptionBox;
        private Button modFolderFileBrowser;
        private TextBox modFolderInputBox;
        private Button gameFolderFileBrowser;
        private TextBox gameDataFolderInputBox;
        private Button installButton;
    }
}