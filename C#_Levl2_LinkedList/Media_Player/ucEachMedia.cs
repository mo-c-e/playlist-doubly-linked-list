using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Media_Player
{
   
    public partial class ucEachMedia : UserControl
    {
        public class MediaEventArgs : EventArgs
        {
            public int MediaID { get; }           // read-only property
            public globalClass.MediaItem Item { get; }  // optional full object

            // Constructor to initialize
            public MediaEventArgs(int mediaID)
            {
                MediaID = mediaID;
            }

            public MediaEventArgs(globalClass.MediaItem item)
            {
                Item = item;
                MediaID = item.Number; // optional convenience
            }
        }
        public event EventHandler<MediaEventArgs> SelectClicked;

        private int RecordID = 0;
        // public int RecordID { get; set; }
        
        public void SetRecord(globalClass.MediaItem item)
        {
            RecordID= item.Number;
            laMediaNumber.Text=item.Number.ToString();
            pbPhoto.SizeMode= PictureBoxSizeMode.StretchImage;

            pbPhoto.Image = File.Exists(item.PhotoPath) ? System.Drawing.Image.FromFile(item.PhotoPath) : Properties.Resources.waves;
            laSurahName.Text=item.SurahName;
            laReciterName.Text=item.ReciterName;
            laTotalTime.Text = item.TotalTime;
            if (IsArabic(item.SurahName) || IsArabic(item.ReciterName))
            {
                laSurahName.RightToLeft = RightToLeft.Yes;
                laReciterName.RightToLeft = RightToLeft.Yes;
            }
            else
            {
                laSurahName.RightToLeft = RightToLeft.No;
                laReciterName.RightToLeft = RightToLeft.No;
            }
        }

        public ucEachMedia()
        {
            InitializeComponent();

           
        }

        private void laMediaNumber_Click(object sender, EventArgs e)
        {

        }

        private void ucEachMedia_Load(object sender, EventArgs e)
        {

        }

        private bool IsArabic(string text)
        {
            // Checks if the string contains Arabic characters
            return text.Any(c => c >= 0x0600 && c <= 0x06FF);  // Unicode range for Arabic
        }

        private void laReciterName_Click(object sender, EventArgs e)
        {

        }

        private void buSelect_Click(object sender, EventArgs e)
        {
            SelectClicked?.Invoke(this, new MediaEventArgs(RecordID));
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
