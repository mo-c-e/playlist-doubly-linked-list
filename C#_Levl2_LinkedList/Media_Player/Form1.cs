using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Microsoft.Win32;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using TheArtOfDevHtmlRenderer.Adapters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static Media_Player.globalClass;

namespace Media_Player
{

    public partial class Form1 : Form
    {
        IWavePlayer waveOut;         // Audio output device
        AudioFileReader audioFile;   // MP3/WAV file reader
        private MMDevice device;
        bool isPaused = false;

        LinkedListNode<MediaItem> CurrentMedia;

        private List<Track> playlist = new List<Track>();

        private LinkedList<globalClass.MediaItem> Linked_PlayList = new LinkedList<globalClass.MediaItem>();

        public class Track
        {
            public string AudioPath { get; set; }
            public string PhotoPath { get; set; }
            public string FolderName { get; set; }

            public int TotalTime { get; set; }

            public string TotalTimebyAudioFile()
            {
               var CurrentAudioFile = new AudioFileReader(this.AudioPath);
                return CurrentAudioFile.TotalTime.ToString(@"hh\:mm\:ss");
            }


            public string Title => Path.GetFileNameWithoutExtension(AudioPath);


            public Track(int totaltime, string audioPath, string photoPath, string folderName)
            {
                this.TotalTime = totaltime;
                AudioPath = audioPath;
                PhotoPath = photoPath;
                FolderName = folderName;
            }
        }


        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            waveOut?.Pause();
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (audioFile != null)
            { 

                guna2ProgressBar1.Value = Math.Min((int)audioFile.CurrentTime.TotalSeconds, guna2ProgressBar1.Maximum);

                laCurrentTime.Text = audioFile.CurrentTime.ToString(@"hh\:mm\:ss");
            }
        }

        private bool BuildPlaylist(string mainFolder)
        {
            if (!Directory.Exists(mainFolder))
            {
                MessageBox.Show(
                    "The file does not exist.",
                    "File Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return false;
            }

            playlist.Clear();

            var subFolders = Directory.GetDirectories(mainFolder);

            

            foreach (var folder in subFolders)
            {
                // Find first MP3 file in this folder
               var mp3File = Directory.GetFiles(folder, "*.mp3").FirstOrDefault();
                var photoFile = Directory.GetFiles(folder, "*.jpg").Concat(Directory.GetFiles(folder, "*.png")).FirstOrDefault();

                if (mp3File != null)
                {
                    audioFile = new AudioFileReader(mp3File);
                    playlist.Add(new Track((int)audioFile.TotalTime.TotalMinutes, mp3File, photoFile, folder));
                }
            }

            if(playlist.Count==0)
            {
                MessageBox.Show(
           "No MP3 files found in the selected folder.",
           "No Tracks Found",
           MessageBoxButtons.OK,
           MessageBoxIcon.Warning
       );
                return false;
            }
            return true;
        }


        private void buPlay_Click(object sender, EventArgs e)
        {
            if (CurrentMedia == null)
                return;

           
            if (waveOut == null)
            {
                Play(CurrentMedia);
                isPaused = false;
                buPlay.Image = Properties.Resources.pause__1_;
                return;
            }

            
            if (!isPaused)
            {
                waveOut.Pause();
                timer1.Stop();
                isPaused = true;
                buPlay.Image = Properties.Resources.play_button__1_;
            }
          
            else
            {
                waveOut.Play();
                timer1.Start();
                isPaused = false;
                buPlay.Image = Properties.Resources.pause__1_;
            }

        }

        private void trackBarVolume_Scroll(object sender, ScrollEventArgs e)
        {
            device.AudioEndpointVolume.MasterVolumeLevelScalar = trackBarVolume.Value / 100f;
        }

        private void buStop_Click(object sender, EventArgs e)
        {
            ResetPlayer();
        }

        private void FillEachRecord()
        {
            laTracksNo.Text = $"{playlist.Count}  {"Tracks"}";
            int counter = 0;
            playlist.ForEach(item =>
            {
                counter++;
                ucEachMedia record = new ucEachMedia();
                record.Margin = new Padding(22, 10, 10, 10); // Left, Top, Right, Bottom
                record.RightToLeft = RightToLeft.Yes;
                string foldername = Path.GetFileName(item.FolderName);
                string[] parts;
                 if (!foldername.Contains('-'))
                {
                    parts = new string[] { "unknown", "unknown" };
                }
                else
                     parts = foldername.Split('-');
                globalClass.MediaItem Mitem = new MediaItem(counter, parts[0].Trim(), parts[1].Trim(), item.AudioPath, item.PhotoPath, item.TotalTimebyAudioFile());

                record.SelectClicked += (sender, e) =>
                {
                    var Record = FindNodeById(e.MediaID);
                    CurrentMedia = Record;
                    FillMainRecord(CurrentMedia.Value);
                    Play(CurrentMedia);
                };
               
                record.SetRecord(Mitem);
                Linked_PlayList.AddLast(Mitem);
                flowLayoutPanel1.Controls.Add(record);

            });
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            

            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select MP3 Folder";
                folderDialog.ShowNewFolderButton = false;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderDialog.SelectedPath;

                    BuildPlaylist(selectedPath);
                    FillEachRecord();
                }
            }
        }


        private void FillMainRecord(globalClass.MediaItem media)
        {
           
            pbMainPicture.Image = File.Exists(media.PhotoPath) ? System.Drawing.Image.FromFile(media.PhotoPath) : Properties.Resources.waves;
            laNameOfPlaying.Text = media.SurahName;
            laReciterName.Text = media.ReciterName;
          var  LoadAudioFile = new AudioFileReader(CurrentMedia.Value.Mp3Path);
            laTotalTime.Text = LoadAudioFile.TotalTime.ToString(@"hh\:mm\:ss");
        }

        LinkedListNode<MediaItem> FindNodeById(int id)
        {
            var node = Linked_PlayList.First;

            while (node != null)
            {
                if (node.Value.Number == id)
                    return node;

                node = node.Next;
            }

            return null;
        }


        private void Play(LinkedListNode<MediaItem> media)
        {
            
            StopPreviousAudio();
            
            audioFile = new AudioFileReader(media.Value.Mp3Path);
            waveOut = new WaveOutEvent(); // Output to speakers
            waveOut.Init(audioFile);

            waveOut.Play();
            isPaused = false;
            // Set ProgressBar maximum to total seconds of the audio
            guna2ProgressBar1.Maximum = (int)audioFile.TotalTime.TotalSeconds;

            guna2ProgressBar1.Value = Math.Min((int)audioFile.CurrentTime.TotalSeconds, guna2ProgressBar1.Maximum);
            timer1.Start();
            laTotalTime.Text = audioFile.TotalTime.ToString(@"hh\:mm\:ss");
        }

        private void buNextRight_Click(object sender, EventArgs e)
        {
            if (CurrentMedia.Next != null )
            {
                CurrentMedia = CurrentMedia.Next;
                ResetPlayButton();
                FillMainRecord(CurrentMedia.Value);

                if (waveOut != null)
                    Play(CurrentMedia);
            }
        }

        private void buNextLeft_Click(object sender, EventArgs e)
        {
            if (CurrentMedia.Previous != null)
            {
              
                CurrentMedia = CurrentMedia.Previous;
                ResetPlayButton();
                FillMainRecord(CurrentMedia.Value);
               if(waveOut != null)
                Play(CurrentMedia);
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetPlayButton()
        {
            if (waveOut != null)
            {


                buPlay.Image = Properties.Resources.pause__1_;
                isPaused = false;
            }
        }

        private void StopPreviousAudio()
        {
            waveOut?.Stop();
            audioFile?.Dispose();
            waveOut?.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var enumerator = new MMDeviceEnumerator();
            device = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);

            trackBarVolume.Value = (int)(device.AudioEndpointVolume.MasterVolumeLevelScalar * 100);

            string chosenFile = GetOrAskFolder();
            if (!BuildPlaylist(chosenFile))
            {
                Application.Exit();
                return;

            }

            FillEachRecord();

            CurrentMedia = FindNodeById(1);
            FillMainRecord(CurrentMedia.Value);
        }

        private void ResetPlayer()
        {
            
            waveOut?.Stop();

            
            waveOut?.Dispose();
            audioFile?.Dispose();

            waveOut = null;
            audioFile = null;

           
            isPaused = false;

           
            timer1.Stop();
            guna2ProgressBar1.Value = 0;
            laCurrentTime.Text = "00:00:00";
            buPlay.Image = Properties.Resources.play_button__1_;
        }

       private string GetOrAskFolder()
    {
        using (RegistryKey key =
            Registry.CurrentUser.CreateSubKey(@"Software\MyMediaPlayer"))
        {
            string folderPath = key.GetValue("LastFolder") as string;

            if (!string.IsNullOrEmpty(folderPath) && Directory.Exists(folderPath))
            {
                return folderPath;
            }

            
            MessageBox.Show(
                "Welcome!\n\nThis is a one-time setup.\nPlease choose a folder to continue.",
                "First-Time Setup",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Select MP3 Folder";
                dialog.ShowNewFolderButton = false;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    folderPath = dialog.SelectedPath;

                    
                    key.SetValue("LastFolder", folderPath);

                    return folderPath;
                }
                else
                {
                    
                    Application.Exit();
                    return null;
                }
            }
        }
    }



}
}
