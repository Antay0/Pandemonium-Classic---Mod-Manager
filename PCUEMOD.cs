using System;
using System.Xml;
using System.Xml.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pandemonium_Classic___Mod_Manager
{
    public partial class PCUEMOD : Form
    {
        public Mod Mod;

        XDocument doc;
        XElement[] installSteps;
        int stepIndex; 
        
        List<InstallerOption> optionList = new();

        public List<string> fileList = new();
        public int installCount = 0;

        public bool selectOne;
        public bool required;

        public PCUEMOD(Mod mod)
        {
            Mod = mod;
            InitializeComponent();

            this.Text = "PCUEMOD Installer: " + Mod.Name;

            // Gets the xml document in question to guide the installer
            doc = XDocument.Load(mod.xmlPath);
            installSteps = doc.Descendants().Elements("installstep").ToArray();
            stepIndex = 0;
            RunInstallStep(0);
        }

        public void RunInstallStep(int index)
        {
            // Reset dialog
            CleanDialog();
            selectOne = false;
            required = false;
            optionList.Clear();

            XElement step = installSteps[index];
            XmlReader reader = step.CreateReader();

            reader.ReadToFollowing("installstep");
            installStepLabel.Text = reader.GetAttribute("name");
            reader.MoveToElement();

            selectOne = reader.GetAttribute("onlyone") == "true" ? true : false;

            required = reader.GetAttribute("required") == "true" ? true : false;

            var optionElements = step.Descendants("option").ToList();
            foreach(var element in optionElements)
            {
                var newOption = new InstallerOption();

                reader = element.CreateReader();
                reader.ReadToFollowing("option");
                string? label = reader.GetAttribute("name");
                if (label != null)
                {
                    newOption.Name = label;
                    optionListBox.Items.Add(label);
                    optionList.Add(newOption);
                }
                else
                {
                    MessageBox.Show("option name is null", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                reader.MoveToElement();
                reader.ReadToDescendant("description");
                newOption.Description = reader.ReadElementContentAsString();

                // Get value from <folder> element
                string folderPath = Path.Combine(Mod.FolderPath, reader.ReadElementContentAsString());
                newOption.Files = Directory.GetFiles(folderPath, "*", SearchOption.AllDirectories).ToList();

                // Get value from <image> element
                string imagePath = Path.Combine(Mod.FolderPath, "PCUEMOD\\images", reader.ReadElementContentAsString());
                 newOption.Image = Image.FromFile(imagePath);
            }
        }

        public void CleanDialog()
        {
            installStepLabel.Text = string.Empty;
            optionListBox.Items.Clear();
            optionDescBox.Text = string.Empty;
            optionThumbnailBox.Image = null;
        }

        private void optionListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (selectOne)
            {
                for (int i = 0; i < optionListBox.Items.Count; i++)
                    if (i != e.Index) optionListBox.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void optionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = optionListBox.SelectedIndex;
            InstallerOption selected = optionList[index];
            if (selected != null)
            {
                if (selected.Description != null)
                    optionDescBox.Text = selected.Description;
                if (selected.Image != null)
                    optionThumbnailBox.Image = selected.Image;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (!required || optionListBox.CheckedItems.Count != 0)
            {
                // Add selected file packs to list of files to install
                foreach (int index in optionListBox.CheckedIndices)
                    fileList.AddRange(optionList[index].Files);

                if (stepIndex < installSteps.Length - 1)
                {
                    stepIndex++;
                    RunInstallStep(stepIndex);
                }
                else InstallFiles();
            }
            else MessageBox.Show("This step requires at least one box to be checked!", "Required Segment", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void InstallFiles()
        {
            var msgResult = MessageBox.Show("Install " + fileList.Count + " files?", "Confirmation",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (msgResult == DialogResult.OK)
            {
                foreach (var file in fileList)
                {
                    int i = file.IndexOf("StreamingAssets");
                    if (i == -1)
                    {
                        // If the indicated substring isn't found, ask whether to continue or exit the installation
                        var errMsgResult = MessageBox.Show("ERROR: substring '\\StreamingAssets' not found in file: " + file, "FilePathError",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        if (errMsgResult == DialogResult.Cancel)
                            return;
                    }
                    else
                    {
                        string newPath = Path.Combine(Properties.Settings.Default.gameDataFolder, file.Remove(0, i));
                        Directory.CreateDirectory(newPath.Remove(newPath.LastIndexOf("\\")));
                        File.Copy(file, newPath, true);

                        installCount++;
                    }
                }
            }
            ExitPCUEMODInstaller();
        }

        private void ExitPCUEMODInstaller()
        {
            MessageBox.Show("Done!");
            this.Close();
        }
    }

    public class InstallerOption
    {
        public string? Name;
        public string? Description;
        public List<string> Files = new();
        public Image? Image;
    }
}
