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

namespace RandLaunch
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void browseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if (Directory.Exists(Properties.Settings.Default.DefaultLocation))
                {
                    fbd.SelectedPath = Properties.Settings.Default.DefaultLocation;
                }

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    int count = 0;
                    List<String> episodes = new List<String>();

                    foreach (var file in Directory.GetFiles(fbd.SelectedPath, "*.*", SearchOption.AllDirectories)
                        .Where(s => s.EndsWith(".mp4") || s.EndsWith(".mkv") || s.EndsWith(".avi")))
                    {
                        episodes.Add(file);
                        count++;
                    }
                    //System.Windows.Forms.MessageBox.Show("Files found: " + count, "Message");
                    Random random = new Random();
                    int randomNumber = random.Next(0, count);

                    var fileName = episodes[randomNumber];
                    string[] parts = fileName.Split('\\');

                    MessageBox.Show("Playing " + parts[parts.Length - 1]);

                    System.Diagnostics.Process.Start(episodes[randomNumber]);

                    this.Close();
                }
            }
        }

        private void setDefaultLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.DefaultLocation = fbd.SelectedPath;
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Default path set: " + fbd.SelectedPath);
                }
            }
        }
    }
}
