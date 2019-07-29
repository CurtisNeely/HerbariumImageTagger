using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomaticHerbariumTagger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFolderPicker_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxFolderPath.Text = fbd.SelectedPath;
            }
        }

        private void ButtonCSVPicker_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxCSVPath.Text = ofd.FileName;
            }
        }

        private void ButtonTagImages_Click(object sender, EventArgs e)
        {
            labelStatus.Text = "Status: Starting!";
            string folderPath = textBoxFolderPath.Text;
            string csvPath = textBoxCSVPath.Text;
            List<Plant> plants = GetPlants(csvPath);
            List<Image> images = GetImages(folderPath);


            labelStatus.Text = "Status: Processing!";
            TagImages(plants, images);


            labelStatus.Text = "Status: Finished!";
        }

        private static List<Plant> GetPlants(string csvPath)
        {
            List<Plant> plants = new List<Plant>();

            using (var reader = new StreamReader(csvPath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    Plant plant = new Plant() { Name = values[0], HAM = values[1] };
                    plants.Add(plant);
                }
            }

            plants.RemoveAt(0);

            return plants;
        }

        private static List<Image> GetImages(string folderPath)
        {
            List<Image> images = new List<Image>();

            DirectoryInfo d = new DirectoryInfo(folderPath);

            FileInfo[] Files = d.GetFiles("*.jpg", SearchOption.AllDirectories);

            foreach (FileInfo file in Files)
            {
                Image image = new Image() { Path = file.FullName };
                images.Add(image);
            }

            return images;
        }

        private static void TagImages(List<Plant> plants, List<Image> images)
        {
            foreach (Image image in images)
            {
                var imageFile = ShellFile.FromFilePath(image.Path);
                string name = imageFile.Name;
                string ham = name.Substring(name.IndexOf("HAM") + 4);
                ham = ham.Replace(".jpg", "");

                Plant plant = plants.FirstOrDefault(p => p.HAM == ham);

                if (plant != null)
                {
                    string[] tags = new string[] { plant.Name };
                    imageFile.Properties.System.Keywords.Value = tags;
                }

            }
        }
    }
}
