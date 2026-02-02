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
            public string SurahName { get; set; }       
            public string ReciterName { get; set; }    
            public string Mp3Path { get; set; }         
            public string PhotoPath { get; set; }
            public int Number { get; set; }

            public string TotalTime { get; set; }


            //  constructor
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
