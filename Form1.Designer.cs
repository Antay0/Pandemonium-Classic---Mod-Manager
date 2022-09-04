namespace Pandemonium_Classic___Mod_Manager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.installButton = new System.Windows.Forms.Button();
            this.uninstallButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.modThumbnailBox = new System.Windows.Forms.PictureBox();
            this.gameDataFolderInputBox = new System.Windows.Forms.TextBox();
            this.gameFolderFileBrowser = new System.Windows.Forms.Button();
            this.modList = new System.Windows.Forms.ListBox();
            this.modFolderFileBrowser = new System.Windows.Forms.Button();
            this.modFolderInputBox = new System.Windows.Forms.TextBox();
            this.modDescriptionBox = new System.Windows.Forms.TextBox();
            this.BackupCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.modThumbnailBox)).BeginInit();
            this.SuspendLayout();
            // 
            // installButton
            // 
            resources.ApplyResources(this.installButton, "installButton");
            this.installButton.Name = "installButton";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // uninstallButton
            // 
            resources.ApplyResources(this.uninstallButton, "uninstallButton");
            this.uninstallButton.Name = "uninstallButton";
            this.uninstallButton.UseVisualStyleBackColor = true;
            this.uninstallButton.Click += new System.EventHandler(this.uninstallButton_Click);
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // folderBrowserDialog1
            // 
            resources.ApplyResources(this.folderBrowserDialog1, "folderBrowserDialog1");
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.ProgramFilesX86;
            // 
            // modThumbnailBox
            // 
            resources.ApplyResources(this.modThumbnailBox, "modThumbnailBox");
            this.modThumbnailBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.modThumbnailBox.Name = "modThumbnailBox";
            this.modThumbnailBox.TabStop = false;
            this.modThumbnailBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gameDataFolderInputBox
            // 
            resources.ApplyResources(this.gameDataFolderInputBox, "gameDataFolderInputBox");
            this.gameDataFolderInputBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.gameDataFolderInputBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.gameDataFolderInputBox.Name = "gameDataFolderInputBox";
            this.gameDataFolderInputBox.TextChanged += new System.EventHandler(this.gameDataFolderInputBox_TextChanged);
            // 
            // gameFolderFileBrowser
            // 
            resources.ApplyResources(this.gameFolderFileBrowser, "gameFolderFileBrowser");
            this.gameFolderFileBrowser.Name = "gameFolderFileBrowser";
            this.gameFolderFileBrowser.UseVisualStyleBackColor = true;
            this.gameFolderFileBrowser.Click += new System.EventHandler(this.button1_Click);
            // 
            // modList
            // 
            resources.ApplyResources(this.modList, "modList");
            this.modList.FormattingEnabled = true;
            this.modList.Name = "modList";
            this.modList.SelectedIndexChanged += new System.EventHandler(this.modList_SelectedIndexChanged);
            // 
            // modFolderFileBrowser
            // 
            resources.ApplyResources(this.modFolderFileBrowser, "modFolderFileBrowser");
            this.modFolderFileBrowser.Name = "modFolderFileBrowser";
            this.modFolderFileBrowser.UseVisualStyleBackColor = true;
            this.modFolderFileBrowser.Click += new System.EventHandler(this.modFolderFileBrowser_Click);
            // 
            // modFolderInputBox
            // 
            resources.ApplyResources(this.modFolderInputBox, "modFolderInputBox");
            this.modFolderInputBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.modFolderInputBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.modFolderInputBox.Name = "modFolderInputBox";
            this.modFolderInputBox.TextChanged += new System.EventHandler(this.modFolderInputBox_TextChanged);
            // 
            // modDescriptionBox
            // 
            resources.ApplyResources(this.modDescriptionBox, "modDescriptionBox");
            this.modDescriptionBox.Name = "modDescriptionBox";
            this.modDescriptionBox.ReadOnly = true;
            // 
            // BackupCheckBox
            // 
            resources.ApplyResources(this.BackupCheckBox, "BackupCheckBox");
            this.BackupCheckBox.Name = "BackupCheckBox";
            this.BackupCheckBox.UseVisualStyleBackColor = true;
            this.BackupCheckBox.CheckedChanged += new System.EventHandler(this.BackupCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.BackupCheckBox);
            this.Controls.Add(this.modDescriptionBox);
            this.Controls.Add(this.modFolderFileBrowser);
            this.Controls.Add(this.modFolderInputBox);
            this.Controls.Add(this.modList);
            this.Controls.Add(this.gameFolderFileBrowser);
            this.Controls.Add(this.gameDataFolderInputBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.uninstallButton);
            this.Controls.Add(this.modThumbnailBox);
            this.Controls.Add(this.installButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.modThumbnailBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button installButton;
        private Button uninstallButton;
        private ProgressBar progressBar1;
        private FolderBrowserDialog folderBrowserDialog1;
        private PictureBox modThumbnailBox;
        private TextBox gameDataFolderInputBox;
        private Button gameFolderFileBrowser;
        private ListBox modList;
        private Button modFolderFileBrowser;
        private TextBox modFolderInputBox;
        private TextBox modDescriptionBox;
        private CheckBox BackupCheckBox;
    }
}