using IteratorYT.Model;

namespace IteratorYT.Iterators
{
    public class Song80Iterator : ISongIterator
    {
        private readonly SongInfo[] _bestSongs;
        private int _position = 0;

        public Song80Iterator(SongInfo[] bestSongs)
        {
            _bestSongs = bestSongs;
        }

        public bool HasNext()
        {
            if (_position < _bestSongs.Length && _bestSongs[_position] != null)
            {
                return true;
            }

            return false;
        }

        public SongInfo Next()
        {
            if (_position < _bestSongs.Length)
            {
                var next = _bestSongs[_position];
                _position++;

                return next;
            }

            return null;
        }

        public void RemoveSongInfo(SongInfo song)
        {
            //Remove Logic so a Array has no open spots between two items that are not null.
        }
    }
}