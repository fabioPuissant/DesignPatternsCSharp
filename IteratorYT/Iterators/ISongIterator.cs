using IteratorYT.Model;

namespace IteratorYT.Iterators
{
    public interface ISongIterator
    {
        public bool HasNext();
        public SongInfo Next();

        public void RemoveSongInfo(SongInfo song);
      
    }
}
