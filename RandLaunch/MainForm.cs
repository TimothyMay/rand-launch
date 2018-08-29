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
        public static XMLProbe _settingsProbe;
        public static string _sampleText;

        public List<FileMetaData> episodes = new List<FileMetaData>();

        public MainForm()
        {
            //Create a new settings probe, providing config path as arg ('\' escaped).
            _settingsProbe = new XMLProbe(Application.StartupPath + "\\Config\\Settings.xml");
            _settingsProbe.SetWorkingNode("rand-launch");
            _sampleText = _settingsProbe.GetSetting("Sample");

            InitializeComponent();
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

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if (Directory.Exists(Properties.Settings.Default.DefaultLocation))
                {
                    fbd.SelectedPath = Properties.Settings.Default.DefaultLocation;
                }

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    episodes.Clear();
                    foreach (var file in Directory.GetFiles(fbd.SelectedPath, "*.*", SearchOption.AllDirectories)
                        .Where(s => s.EndsWith(".mp4") || s.EndsWith(".mkv") || s.EndsWith(".avi")))
                    {
                        FileMetaData fileMeta = new FileMetaData();
                        fileMeta.Path = file;
                        fileMeta.FileName = Path.GetFileNameWithoutExtension(file);
                        fileMeta.Extension = Path.GetExtension(file);

                        episodes.Add(fileMeta);
                    }

                    DataGridViewColumn column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "FileName";
                    column.Name = "File Name";
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridViewFoundFiles.Columns.Add(column);

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "Extension";
                    column.Width = 60;
                    column.Name = "Extension";
                    dataGridViewFoundFiles.Columns.Add(column);

                    dataGridViewFoundFiles.AutoGenerateColumns = false;
                    dataGridViewFoundFiles.DataSource = episodes;
                    dataGridViewFoundFiles.ClearSelection();
                }
            }
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            //System.Windows.Forms.MessageBox.Show("Files found: " + count, "Message");
            Random random = new Random();
            int randomNumber = random.Next(0, episodes.Count - 1);
            var fileMetaData = episodes[randomNumber];

            MessageBox.Show("Playing " + fileMetaData.FileName);

            System.Diagnostics.Process.Start(fileMetaData.Path);

            //this.Close();
        }
    }
}
