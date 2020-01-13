using System;
using IteratorYT.Iterators;

namespace IteratorYT
{
    public class DiscJockey
    {
        private ISongIterator _songsOfThe70S;
        private ISongIterator _songsOfThe80S;
        private ISongIterator _songsOfThe90S;

        public DiscJockey(ISongIterator songsOfThe70S, ISongIterator songsOfThe80S, ISongIterator songsOfThe90S)
        {
            _songsOfThe70S = songsOfThe70S;
            _songsOfThe80S = songsOfThe80S;
            _songsOfThe90S = songsOfThe90S;
        }

        public void ShowSongs()
        {
            Console.WriteLine("Songs of the 70's:\n");
            IterateSongs(_songsOfThe70S);
             gjn
            Console.WriteLine("\nSongs of the 80's:\n");
            IterateSongs(_songsOfThe80S);

            Console.WriteLine("\nSongs of the 90's:\n");
            IterateSongs(_songsOfThe90S);
        }

        private void IterateSongs(ISongIterator songsOfThe70S)
        {
            foreach (var songInfo in _songsOfThe70S.CreateIterator())
            {
                Console.WriteLine(songInfo);
            }
        }
    }
}
