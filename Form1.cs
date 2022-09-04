namespace Pandemonium_Classic___Mod_Manager
{
    using System.Xml;
    using System.Diagnostics;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void modListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void gameFolder_TextChanged(object sender, EventArgs e)
        {

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
            int folderCount = 0;
            int fileCount = 0;

            string mod = Mods[modList.SelectedIndex].modulesPath;

            PCUEMOD installer = new(mod);

            installer.ShowDialog();

            if (string.IsNullOrEmpty(mod))
            {
                var result = MessageBox.Show("ERROR: string 'toInstall' is NULL or empty", "FilePathError",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(folderCount + " folders(" + fileCount + " files) installed.", "Mod Installer");
        }

        private int removeFiles(string mod)
        {
            string modPath = Path.Combine(modFolderInputBox.Text, mod);
            string[] files = Directory.GetFiles(Path.Combine(modPath, "StreamingAssets"), "*", SearchOption.AllDirectories);

            int count = 0;

            foreach (string file in files)
            {
                File.Move(file.Replace(modFolderInputBox.Text, backupDir), file.Replace(modFolderInputBox.Text, gameDataFolderInputBox.Text).Replace("\\", "/"), true);
                backedUpFiles.Remove(file.Replace(modFolderInputBox.Text, backupDir));
                count++;
            }
            return count;
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

        private void modList_SelectedIndexChanged(object sender, EventArgs e)
        {
            modDescriptionBox.Text = string.Empty;
            modThumbnailBox.Image = null;

            Mod mod = Mods[modList.SelectedIndex];

            modDescriptionBox.Text = mod.Description;

            string imageLocation = Path.Combine(mod.FolderPath, "PCUEMOD\\preview.png");
            if (File.Exists(imageLocation))
            {
                modThumbnailBox.Image = Image.FromFile(imageLocation);
            }
        }

        private void modFolder_TextChanged(object sender, EventArgs e) //Fills modlist when mod directory is changed
        {
            var Files = Directory.GetFiles(modFolderInputBox.Text, "info.xml", SearchOption.AllDirectories);

            foreach (string file in Files)
            {
                Mod mod = new(file);
                Mods.Add(mod);
                modList.Items.Add(mod.Name);
            }
        }

        private void BackupCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            uninstallButton.Visible = BackupCheckBox.Checked;
        }

        private void modFolderInputBox_TextChanged(object sender, EventArgs e) //Fills modlist when mod directory is changed
        {
            modFolder = modFolderInputBox.Text;
            var Files = Directory.GetFiles(modFolder, "info.xml", SearchOption.AllDirectories);

            foreach (string file in Files)
            {
                Mod mod = new(file);
                Mods.Add(mod);
                modList.Items.Add(mod.Name);
            }
        }

        private void gameDataFolderInputBox_TextChanged(object sender, EventArgs e)
        {
            gameDataFolder = gameDataFolderInputBox.Text;
        }

        public List<Mod> Mods = new();

        public static string modFolder = string.Empty;
        public static string gameDataFolder = string.Empty;

        private string backupDir = Path.Combine(Application.StartupPath, "FileBackup");
        private List<string> backedUpFiles = new();
    }

    public class Mod
    {
        public string Name;
        public string Description;

        public string FolderPath; // Path to base folder that contains all other components of the mod.
        public string InfoPath; // Path to info.xml
        public string modulesPath; // Path to modules.xml

        public Mod (string filePath)
        {
            FolderPath = filePath.Replace("PCUEMOD\\info.xml", "");
            InfoPath = filePath;
            modulesPath = filePath.Replace("info.xml", "modules.xml");

            XmlReader reader = XmlReader.Create(filePath);

            reader.ReadToFollowing("name");
            Name = reader.ReadElementContentAsString();

            reader.ReadToFollowing("description");
            Description = reader.ReadElementContentAsString();
        }
    }
}