using System;
using System.Collections.Generic;
using System.Text;
using IteratorYT.Model;

namespace IteratorYT.Iterators
{
    public class Songs70sIterator : ISongIterator
    {
        private readonly IList<SongInfo> _songInfos;
        private int _position = 0;
        public Songs70sIterator(IList<SongInfo> songInfos)
        {
            _songInfos = songInfos;
        }

        public bool HasNext()
        {
            if (_songInfos.Count > _position && _songInfos[_position] != null)
            {
                return true;
            }

            return false;
        }

        public SongInfo Next()
        {
            
            if (_songInfos.Count > _position)
            {
                var next = _songInfos[_position];
                _position++;

                return next;
            }

            return null;
        }

        public void RemoveSongInfo(SongInfo song)
        {
            // Logic to remove and reorder the list.
        }
    }
}
