using System;
using System.IO;
using System.IO.Compression;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Winforms_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedFilePath = null;
            string itemPath = null;
            string systemPath = null;
            using var openFileDialog = new OpenFileDialog
            {
                Filter = "RPG Maker Save Files (*.lsd;*.rxdata;*.rvdata;*.rvdata2;*.rpgsave)|*.lsd;*.rxdata;*.rvdata;*.rvdata2;*.rpgsave",
                Title = "Select a file"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                savePathLabel.Text = "Path: " + selectedFilePath;
                ConvertRpgSaveToJson(selectedFilePath);

                itemPath = Path.Combine(Path.GetDirectoryName(selectedFilePath), "..", "data", "Items.json");
                itemPath = Path.GetFullPath(itemPath);

                systemPath = Path.Combine(Path.GetDirectoryName(selectedFilePath), "..", "data", "System.json");
                systemPath = Path.GetFullPath(systemPath);
                if (File.Exists(itemPath))
                {
                    itemPathLabel.Text = "Path: " + itemPath;
                }
                else
                {
                    itemPath = null;
                    itemPathLabel.Text = "Path: ";
                    MessageBox.Show("Item path not found, please manually locate.");
                }
                if (File.Exists(systemPath))
                {
                    systemPathLabel.Text = "Path: " + systemPath;
                }
                else
                {
                    systemPath = null;
                    systemPathLabel.Text = "Path: ";
                    MessageBox.Show("System path not found, please manually locate.");
                }
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedFilePath = null;
            using var openFileDialog = new OpenFileDialog
            {
                Filter = "Items.json|*.json",
                Title = "Select a file"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                itemPathLabel.Text = "Path: " + Path.GetFileName(selectedFilePath);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void systemButton_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog
            {
                Filter = "System.json|*.json",
                Title = "Select a file"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                systemPathLabel.Text = "Path: " + selectedFilePath;
            }
        }

        private void systemPathLabel_Click(object sender, EventArgs e)
        {

        }

        private void itemPathLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateMHP()
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

    }
}
