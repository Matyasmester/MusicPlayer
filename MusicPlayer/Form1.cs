using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using WMPLib;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using TagLib;

namespace MusicPlayer
{
    public partial class MainForm : Form
    {
        private static WindowsMediaPlayer player = new WindowsMediaPlayer();

        private List<string> Paths = new List<string>();

        private const double NONE = 0.00;
        private double timePausedAt = NONE;
        private bool IsPaused = false;

        private Timer progressUpdateTimer = new Timer();

        public MainForm()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += MainForm_DragEnter;
            this.DragDrop += MainForm_DragDrop;

            SongsListView.DoubleClick += SongsListView_DoubleClick;

            progressUpdateTimer.Tick += ProgressUpdateTimer_Tick;
            progressUpdateTimer.Interval = 1000;
        }

        private void ProgressUpdateTimer_Tick(object sender, EventArgs e)
        {
            SongProgressBar.Value = (int)player.controls.currentPosition;
        }

        private void SongsListView_DoubleClick(object sender, EventArgs e)
        {
            PlayButton.PerformClick();
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach(string file in files)
            {
                if(!IsValidMusicFile(file)) continue;

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
            TagLib.File tagFile = TagLib.File.Create(path);
            Tag tag = tagFile.Tag;

            string[] properties = new string[3];

            properties[0] = tag.Title;
            properties[1] = tag.FirstAlbumArtist + " - " + tag.Album;
            properties[2] = tagFile.Properties.Duration.ToString(@"mm\:ss");

            return properties;
        }

        private bool IsValidMusicFile(string path)
        {
            FileInfo info = new FileInfo(path);

            IWMPMedia media = player.newMedia(path);

            return (info.Extension.Equals(".mp3") || info.Extension.Equals(".flac")) && media.duration > 0;
        }

        private void PlayMusicFile(string path)
        {
            player.URL = path;

            player.controls.play();

            progressUpdateTimer.Start();

            IsPaused = false;
        }

        private void ResumePlay()
        {
            player.controls.currentPosition = timePausedAt;

            player.controls.play();

            progressUpdateTimer.Start();

            IsPaused = false;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (IsPaused)
            {
                ResumePlay();
                return;
            }

            foreach (int index in SongsListView.SelectedIndices)
            {
                string current = Paths[index];

                SongProgressBar.Maximum = (int)player.newMedia(current).duration;

                PlayMusicFile(current);

                // MultiSelect on SongsListView is set to false, meaning there can only be 1 selected item at a time
                PlaybackLabel.Text = "Now playing: " + SongsListView.SelectedItems[0].Text;
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            player.controls.stop();

            timePausedAt = NONE;

            IsPaused = false;

            PlaybackLabel.Text = "Playback stopped.";

            progressUpdateTimer.Stop();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            if (IsPaused)
            {
                ResumePlay();
                return;
            }

            IsPaused = true;

            timePausedAt = player.controls.currentPosition;

            player.controls.pause();

            progressUpdateTimer.Stop();
        }

        private void VolumeBar_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = VolumeBar.Value;
        }

        private void SongsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SongProgressBar_Click(object sender, EventArgs e)
        {

        }
    }
}
