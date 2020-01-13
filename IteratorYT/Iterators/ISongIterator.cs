
using System.Collections.Generic;
using IteratorYT.Model;

namespace IteratorYT.Iterators
{
    public interface ISongIterator
    {
        IEnumerable<SongInfo> CreateIterator();
    }
}
