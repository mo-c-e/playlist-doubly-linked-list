namespace C__Levl2_LinkedList
{
    internal class Program
    {

        public class clsMusic
        {
            public string Title { get; set; }
            public string Artist { get; set; }
            public string Album { get; set; }
            public string Genre { get; set; }
            public int Duration { get; set; } // in seconds
            public int PlayCount { get; set; }
            public DateTime LastPlayed { get; set; }
            public string FilePath { get; set; }

            // Constructor
            public clsMusic(string title, string artist, string album, string genre, int duration, string filePath)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Genre = genre;
                Duration = duration;
                FilePath = filePath;
                PlayCount = 0;
                LastPlayed = DateTime.MinValue;
            }

            // Display nicely
            public override string ToString()
            {
                return $"{Title} by {Artist} [{Album}] - {Genre} ({Duration / 60}:{Duration % 60:D2})";
            }
        }

        static void Main(string[] args)
        {
           LinkedList<clsMusic> text = new LinkedList<clsMusic>();

            Console.WriteLine("Please Enter Text");
            string line = Console.ReadLine();



        }
    }
}
