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
                Filter = "RPGMAKER 2000/2003 (*.lsd)|*.lsd|RPGMAKER XP (*.rxdata)|*.rxdata|RPGMAKER VX (*.rvdata)|*.rvdata|RPGMAKER VX Ace (*.rvdata2)|.rvdata2|RPGMAKER MV (*.rpgsave)|*.rpgsave",
                Title = "Select a file"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                savePathLabel.Text = "Path: " + selectedFilePath;
                itemPath = Path.Combine(Path.GetDirectoryName(selectedFilePath), "..", "data", "Items.json");
                itemPath = Path.GetFullPath(itemPath);

                systemPath = Path.Combine(Path.GetDirectoryName(selectedFilePath), "..", "data", "System.json");
                systemPath = Path.GetFullPath(systemPath);
                if (File.Exists(itemPath))
                {
                    itemPathLabel.Text = "Path: " + itemPath;
                } else
                {
                    itemPath = null;
                    itemPathLabel.Text = "Path: ";
                    MessageBox.Show("Item path not found, please manually locate.");
                }
                if (File.Exists(systemPath))
                {
                    systemPathLabel.Text = "Path: " + systemPath;
                } else
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
    }
}
