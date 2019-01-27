using System;

namespace Radio
{
    public class Song
    {
        private string artistName;
        private string songName;
        private int[] duration;

        public Song(string artist, string title, int[] duration)
        {
            this.ArtistName = artist;
            this.SongName = title;
            this.Duration = duration;
        }
        protected string ArtistName
        {
            get => artistName;
            set
            {
                if (value.Length < 3 || value.Length > 20) throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
                artistName = value;
            }
        }

        protected string SongName
        {
            get => songName;
            set
            {
                if (value.Length < 3 || value.Length > 30) throw new ArgumentException("Song name should be between 3 and 30 symbols.");
                songName = value;
            }
        }

        public int[] Duration
        {
            get => duration;
            set
            {
                if (value[0] < 0 || value[0] > 14) throw new ArgumentException("Song minutes should be between 0 and 14.");
                if (value[1] < 0 || value[1] > 59) throw new ArgumentException("Song seconds should be between 0 and 59.");
             //   if (value[0] == 0 && value[1] == 0) throw new ArgumentException("Invalid song length.");
               duration = value;
            }
        }
    }
}