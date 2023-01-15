using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using WMPLib;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace MusicPlayer
{
    public partial class MainForm : Form
    {
        private static WindowsMediaPlayer player = new WindowsMediaPlayer();

        private List<string> Paths = new List<string>();

        public MainForm()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += MainForm_DragEnter;
            this.DragDrop += MainForm_DragDrop;
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach(string file in files)
            {
                if(!IsValidMP3File(file)) continue;

                Paths.Add(file);

                string[] properties = GetProperties(file);

                ListViewItem item = new ListViewItem(properties);

                SongsListView.Items.Add(item);
            }
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private string[] GetProperties(string path)
        {
            FileInfo info = new FileInfo(path);

            IWMPMedia media = player.newMedia(path);

            string[] properties = new string[3];

            properties[0] = info.Name.TrimEnd(info.Extension.ToCharArray());
            properties[1] = "";
            properties[2] = media.durationString;

            return properties;
        }

        private bool IsValidMP3File(string path)
        {
            FileInfo info = new FileInfo(path);

            IWMPMedia media = player.newMedia(path);

            return info.Extension.Equals(".mp3") && media.duration > 0;
        }

        private void PlayMP3File(string path)
        {
            player.URL = path;

            player.controls.play();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            foreach (int index in SongsListView.SelectedIndices)
            {
                string current = Paths[index];

                PlayMP3File(current);

                PlaybackLabel.Text = "Now playing: " + SongsListView.SelectedItems[0].Text;
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            player.controls.stop();

            PlaybackLabel.Text = "Playback stopped.";
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            player.controls.pause();
        }
    }
}
