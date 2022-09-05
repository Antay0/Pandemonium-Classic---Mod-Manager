namespace Pandemonium_Classic___Mod_Manager
{
    using System.Xml;
    using System.Diagnostics;

    public partial class PCUEModManager : Form
    {
        public PCUEModManager()
        {
            InitializeComponent();

            modFolderInputBox.Text = Properties.Settings.Default.modFolder;
            gameDataFolderInputBox.Text = Properties.Settings.Default.gameDataFolder;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    gameDataFolderInputBox.Text = fbd.SelectedPath;
                }
            }
        }

        private void uninstallButton_Click(object sender, EventArgs e)
        {
            /*
            int fileCount = 0;

            List<string> toRemove = new List<string>();

            foreach (var item in modList.SelectedItems)
                toRemove.Add((string)item);

            foreach (string dir in toRemove)
            {
                // Ignore already installed and backed up files
                if (dir.Substring(0, 1) == "+")
                {
                    fileCount += removeFiles(dir.Replace("\\", "/"));
                }
            }
            MessageBox.Show(fileCount + " files removed.", "Mod Installer");
            */
        }

        private void installButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.modFolder)
                && !string.IsNullOrEmpty(Properties.Settings.Default.gameDataFolder))
            {
                string mod = Mods[modListBox.SelectedIndex].xmlPath;
                if (string.IsNullOrEmpty(mod))
                {
                    var result = MessageBox.Show("ERROR: string 'toInstall' is NULL or empty", "FilePathError",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                PCUEMOD installer = new(Mods[modListBox.SelectedIndex]);
                installer.ShowDialog();
            }
            else
            {
                MessageBox.Show("Game Data or Mod folders are not declared.", "Empty Directory",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void modFolderFileBrowser_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    modFolderInputBox.Text = fbd.SelectedPath;
                }
            }
        }

        private void BackupCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            uninstallButton.Visible = BackupCheckBox.Checked;
        }

        private void modFolderInputBox_TextChanged(object sender, EventArgs e) //Fills modlist when mod directory is changed
        {
            Properties.Settings.Default.modFolder = modFolderInputBox.Text;
            Properties.Settings.Default.Save();
            var Files = Directory.GetFiles(Properties.Settings.Default.modFolder, "mod.xml", SearchOption.AllDirectories);

            foreach (string file in Files)
            {
                Mod mod = new(file);
                if (mod.Name != null)
                {
                    Mods.Add(mod);
                    modListBox.Items.Add(mod.Name);
                }
            }
        }

        private void gameDataFolderInputBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.gameDataFolder = gameDataFolderInputBox.Text;
            Properties.Settings.Default.Save();
        }

        private void modListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modListBox.SelectedIndex >= 0 
                && modListBox.SelectedIndex < modListBox.Items.Count
                && modListBox.Items.Count != 0)
            {
                modDescriptionBox.Text = string.Empty;
                modThumbnailBox.Image = null;

                Mod mod = Mods[modListBox.SelectedIndex];

                modDescriptionBox.Text = mod.Description;

                string imageLocation = Path.Combine(mod.FolderPath, "PCUEMOD\\preview.png");
                if (File.Exists(imageLocation))
                {
                    modThumbnailBox.Image = Image.FromFile(imageLocation);
                }
            }
        }

        public List<Mod> Mods = new();

        private string backupDir = Path.Combine(Application.StartupPath, "FileBackup");
        private List<string> backedUpFiles = new();
    }

    public class Mod
    {
        public string? Name;
        public string? Description;

        public string FolderPath; // Path to base folder that contains all other components of the mod.
        public string xmlPath; // Path to mod.xml

        public Mod (string filePath)
        {
            FolderPath = filePath.Replace("PCUEMOD\\mod.xml", "");
            xmlPath = filePath;

            XmlReader reader = XmlReader.Create(filePath);

            reader.ReadToFollowing("mod");
            Name = reader.GetAttribute("name");

            reader.ReadToDescendant("description");
            Description = reader.ReadElementContentAsString();
        }
    }
}