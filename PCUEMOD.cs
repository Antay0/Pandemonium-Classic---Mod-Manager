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
        public string Modules;

        XDocument doc;
        XElement[] installSteps;
        int stepIndex;

        public List<string> fileList = new();

        public bool selectOne;

        List<List<string>> optionFileLists = new();

        public PCUEMOD(string modules)
        {
            Modules = modules;
            InitializeComponent();

            // Gets the xml document in question to guide the installer
            doc = XDocument.Load(Modules);
            installSteps = doc.Descendants().Elements("installsteps").ToArray();
            RunInstallStep(0);
        }

        public void RunInstallStep(int index)
        {
            XElement step = installSteps[index];
            XmlReader reader = step.CreateReader();

            installStepLabel.Text = reader.GetAttribute("name");
            reader.MoveToElement();

            reader.GetAttribute("type");
            selectOne = reader.Value == "SelectOne" ? true : false;

            var options = step.Descendants("option");
            foreach(var option in options)
            {
                reader = option.CreateReader();
                string? label = reader.GetAttribute("name");
                if (label != null)
                    optionListBox.Items.Add(label);
                else
                    return;
                
                reader.MoveToElement();
                reader.ReadToDescendant("description");
                optionDescBox.Text = reader.Value;
                
                reader.Read(); // Reads to image folder path
                optionFileLists.Add(Directory.GetFiles(reader.Value, "*", SearchOption.AllDirectories).ToList());

                reader.Read(); // Reads to option image path
                optionImageBox.Image = Image.FromFile(reader.Value);
            }
        }

        private void optionListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (selectOne)
            {
                for (int i = 0; i < optionListBox.Items.Count; i++)
                    optionListBox.SetItemChecked(i, false);

                optionListBox.SetItemChecked(e.Index, true);
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            // Add selected file packs to list of files to install
            foreach (int index in optionListBox.CheckedItems)
                fileList.AddRange(optionFileLists[index]);

            stepIndex++;
            if (stepIndex < installSteps.Length)
                RunInstallStep(stepIndex);
            else InstallFiles();
        }

        private void InstallFiles()
        {
            var msgResult = MessageBox.Show("Install " + fileList.Count + " files?", "Confirmation",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (msgResult == DialogResult.OK)
            {
                foreach (var file in fileList)
                {
                    int i = file.IndexOf("\\StreamingAssets");
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
                        string newPath = Path.Combine(Form1.gameDataFolder, file.Remove(0, i));
                        File.Copy(file, newPath, true);
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
}
