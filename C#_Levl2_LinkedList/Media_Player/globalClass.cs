using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Player
{
    public static class globalClass
    {
        public  class MediaItem
        {
            public string SurahName { get; set; }       // e.g., "Al-Fatiha"
            public string ReciterName { get; set; }     // e.g., "Abdul Basit"
            public string Mp3Path { get; set; }         // full path to mp3 file
            public string PhotoPath { get; set; }
            public int Number { get; set; }

            public string TotalTime { get; set; }


            // Optional constructor
            public MediaItem(int no, string surahName, string reciterName, string mp3Path, string photoPath, string totalTime)
            {
                this.Number = no;
                SurahName = surahName;
                ReciterName = reciterName;
                Mp3Path = mp3Path;
                PhotoPath = photoPath;
                TotalTime = totalTime;
            }
        }
    }
}
