using Dualitone.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IrrKlang;

namespace Dualitone
{
    public partial class MainForm : Form
    {
        private string workingDir = "";

        private ISoundEngine songEngine1 = new ISoundEngine();
        private ISoundEngine songEngine2 = new ISoundEngine();

        private bool playing = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Settings.Default.WorkingDir != null)
            {
                workingDir = Settings.Default.WorkingDir;
            }  
        }

        public string WorkingDir
        {
            get { return workingDir; }
            set
            {
                workingDir = value;
                Settings.Default.WorkingDir = value; // save the working directory for later
                Settings.Default.Save();
            }
        }

        private void workingDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // select a new working directory

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.SelectedPath = workingDir; // start the search at the current working directory

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                WorkingDir = dialog.SelectedPath; // save the new working directory
            }

            dialog.Dispose(); // clean up
        }

        private void loadButton1_Click(object sender, EventArgs e)
        {
            loadSong(songBox1, songEngine1);
        }

        private void loadButton2_Click(object sender, EventArgs e)
        {
            loadSong(songBox2, songEngine2);
        }

        private void loadSong(TextBox songBox, ISoundEngine songEngine)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = workingDir;

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string fullPath = dialog.FileName;
                string relativePath = fullPath.Replace(workingDir + "\\", "");

                songBox.Text = relativePath;
                songEngine.Play2D(fullPath, true, true);
            }

            dialog.Dispose();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (songBox1.Text == "" || songBox2.Text == "")
                return; // both songs must be loaded first.

            // toggle playback
            songEngine1.SetAllSoundsPaused(playing);
            songEngine2.SetAllSoundsPaused(playing);
            playing = !playing;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            songEngine1.StopAllSounds();
            songEngine2.StopAllSounds();

            playing = false;
        }
    }
}
