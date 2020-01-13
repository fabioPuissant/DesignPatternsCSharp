using System.Collections.Generic;
using IteratorYT.Iterators;
using IteratorYT.Model;

namespace IteratorYT
{
    public class SongsOfThe80s : ISongIterator
    {
        private int index;

        private SongInfo[] _bestSongs;
        public SongInfo[] Best80sSongs => _bestSongs;

        public SongsOfThe80s()
        {
            _bestSongs = new SongInfo[3];

            AddSong("Roam", "B52s", 1989);
            AddSong("Cruel Summer", "Bananarama", 1984);
            AddSong("Head over Heels", "Tears for Fears", 1985);
        }


        private void AddSong(string songName, string bandName, int releaseYear)
        {
            _bestSongs[index] = new SongInfo(songName, bandName, releaseYear);
            index++;
        }

        public IEnumerable<SongInfo> CreateIterator()
        {
            return _bestSongs;
        }
    }
}
