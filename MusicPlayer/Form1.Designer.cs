namespace MusicPlayer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PlayButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.SongsListView = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Artist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Duration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlaybackLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.VolumeBar = new System.Windows.Forms.TrackBar();
            this.SongProgressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayButton.BackgroundImage")));
            this.PlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayButton.Location = new System.Drawing.Point(265, 12);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(40, 40);
            this.PlayButton.TabIndex = 0;
            this.toolTip1.SetToolTip(this.PlayButton, "Start / Resume playback ");
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StopButton.BackgroundImage")));
            this.StopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StopButton.Location = new System.Drawing.Point(199, 12);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(40, 40);
            this.StopButton.TabIndex = 1;
            this.toolTip1.SetToolTip(this.StopButton, "Stop playback");
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PauseButton.BackgroundImage")));
            this.PauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PauseButton.Location = new System.Drawing.Point(332, 12);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(40, 40);
            this.PauseButton.TabIndex = 2;
            this.toolTip1.SetToolTip(this.PauseButton, "Pause / Resume playback");
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // SongsListView
            // 
            this.SongsListView.BackColor = System.Drawing.SystemColors.Window;
            this.SongsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Artist,
            this.Duration});
            this.SongsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SongsListView.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SongsListView.HideSelection = false;
            this.SongsListView.Location = new System.Drawing.Point(12, 109);
            this.SongsListView.MultiSelect = false;
            this.SongsListView.Name = "SongsListView";
            this.SongsListView.Size = new System.Drawing.Size(570, 530);
            this.SongsListView.TabIndex = 3;
            this.SongsListView.UseCompatibleStateImageBehavior = false;
            this.SongsListView.View = System.Windows.Forms.View.Details;
            this.SongsListView.SelectedIndexChanged += new System.EventHandler(this.SongsListView_SelectedIndexChanged);
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 240;
            // 
            // Artist
            // 
            this.Artist.Text = "Artist / Album";
            this.Artist.Width = 220;
            // 
            // Duration
            // 
            this.Duration.Text = "Duration";
            this.Duration.Width = 80;
            // 
            // PlaybackLabel
            // 
            this.PlaybackLabel.AutoSize = true;
            this.PlaybackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlaybackLabel.Location = new System.Drawing.Point(9, 76);
            this.PlaybackLabel.Name = "PlaybackLabel";
            this.PlaybackLabel.Size = new System.Drawing.Size(120, 16);
            this.PlaybackLabel.TabIndex = 4;
            this.PlaybackLabel.Text = "Playback stopped.";
            // 
            // VolumeBar
            // 
            this.VolumeBar.Location = new System.Drawing.Point(431, 12);
            this.VolumeBar.Maximum = 100;
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.Size = new System.Drawing.Size(104, 45);
            this.VolumeBar.TabIndex = 5;
            this.toolTip1.SetToolTip(this.VolumeBar, "Volume");
            this.VolumeBar.Value = 100;
            this.VolumeBar.Scroll += new System.EventHandler(this.VolumeBar_Scroll);
            // 
            // SongProgressBar
            // 
            this.SongProgressBar.Location = new System.Drawing.Point(431, 63);
            this.SongProgressBar.Name = "SongProgressBar";
            this.SongProgressBar.Size = new System.Drawing.Size(104, 15);
            this.SongProgressBar.TabIndex = 6;
            this.toolTip1.SetToolTip(this.SongProgressBar, "Song progress");
            this.SongProgressBar.Click += new System.EventHandler(this.SongProgressBar_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(594, 651);
            this.Controls.Add(this.SongProgressBar);
            this.Controls.Add(this.VolumeBar);
            this.Controls.Add(this.PlaybackLabel);
            this.Controls.Add(this.SongsListView);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.PlayButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Music Player";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.ListView SongsListView;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Duration;
        private System.Windows.Forms.ColumnHeader Artist;
        private System.Windows.Forms.Label PlaybackLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TrackBar VolumeBar;
        private System.Windows.Forms.ProgressBar SongProgressBar;
    }
}

