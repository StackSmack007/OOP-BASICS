using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Radio
{
    class SongCollection
    {
        private List<Song> playlist;
        public SongCollection()
        {
            Playlist = new List<Song>();
        }

        private List<Song> Playlist { get => playlist; set => playlist = value; }

        public void AddSong(string singer, string title, int[] duration)
        {
            try
            {
                Playlist.Add(new Song(singer, title, duration));
                Console.WriteLine("Song added.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Songs added: {Playlist.Count}");
            TimeSpan totalTime;
            playlist.ForEach(x => totalTime+=GetTime(x.Duration));
            sb.Append($"Playlist length: {totalTime.Days * 24 + totalTime.Hours}h {totalTime.Minutes}m {totalTime.Seconds}s");
            return sb.ToString();
        }
        private TimeSpan GetTime(int[] minsSecs)
        {
            return TimeSpan.ParseExact($"{minsSecs[0]}-{minsSecs[1]}","m\\-s",CultureInfo.InvariantCulture);
        }
    }
}