using System;
using IteratorYT.Iterators;

namespace IteratorYT
{
    public class DiscJockey
    {
        private ISongIteratorCreator _songsOfThe70S;
        private ISongIteratorCreator _songsOfThe80S;
        private ISongIteratorCreator _songsOfThe90S;

        public DiscJockey(ISongIteratorCreator songsOfThe70S, ISongIteratorCreator songsOfThe80S, ISongIteratorCreator songsOfThe90S)
        {
            _songsOfThe70S = songsOfThe70S;
            _songsOfThe80S = songsOfThe80S;
            _songsOfThe90S = songsOfThe90S;
        }

        public void ShowSongs()
        {
            Console.WriteLine("Songs of the 70's:\n");
            IterateSongs(_songsOfThe70S);
             
            Console.WriteLine("\nSongs of the 80's:\n");
            IterateSongs(_songsOfThe80S);

            Console.WriteLine("\nSongs of the 90's:\n");
            IterateSongs(_songsOfThe90S);
        }

        private void IterateSongs(ISongIteratorCreator songIteratorCreator)
        {
            var iterator = songIteratorCreator.CreateIterator();

            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Next());
            }
        }
    }
}
