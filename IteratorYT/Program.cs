using System;

namespace IteratorYT
{
    public class Program
    {
        static void Main(string[] args)
        {
            var songs70 = new SongsOfThe70s();
            var songs80 = new SongsOfThe80s();
            var songs90 = new SongsOfThe90s();
            DiscJockey dj = new DiscJockey(songs70, songs80, songs90);

            dj.ShowSongs();
        }
    }
}
