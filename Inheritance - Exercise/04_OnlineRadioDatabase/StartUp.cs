using System;
using System.Linq;
namespace Radio
{
    class StartUp
    {
        static void Main()
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            SongCollection playlist = new SongCollection();

            for (int i = 0; i < numberOfInputs; i++)
            {
                string[] input = Console.ReadLine().Split(';');
                string artistName = input[0];
                string songName = input[1];
                int[] time = input[2].Split(':').Select(x=>int.Parse(x.Trim())).ToArray();
                try
                {
                    playlist.AddSong(artistName, songName, time);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
            Console.WriteLine(playlist);
        }
    }
}