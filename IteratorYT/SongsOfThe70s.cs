using System.Collections.Generic;
using IteratorYT.Iterators;
using IteratorYT.Model;

namespace IteratorYT
{
    public class SongsOfThe70s: ISongIterator
    {
        private IList<SongInfo> _bestSongs;
        public IList<SongInfo> Best70sSongs => _bestSongs;

        public SongsOfThe70s()
        {
            _bestSongs = new List<SongInfo>();

            AddSong("Imagine", "John Lennon", 1971);
            AddSong("American Pie", "Don McLean", 1971);
            AddSong("I Will Survive", "Gloria Gaynor", 1979);
        }


        private void AddSong(string songName, string bandName, int releaseYear)
        {
            _bestSongs.Add(new SongInfo(songName, bandName, releaseYear));
        }

        public IEnumerable<SongInfo> CreateIterator()
        {
            return _bestSongs;
        }
    }
}
