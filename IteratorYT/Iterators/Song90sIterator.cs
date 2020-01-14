using System;
using System.Collections.Generic;
using System.Linq;
using IteratorYT.Model;

namespace IteratorYT.Iterators
{
    public class Song90sIterator: ISongIterator
    {
        private readonly List<SongInfo> _bestSongsValues;
        private int _position = 0;

        public Song90sIterator(Dictionary<int, SongInfo> bestSongsValues)
        {
            _bestSongsValues = bestSongsValues.Values.Select((k,v)=> k).ToList();
        }
        public bool HasNext()
        {
            if (_position < _bestSongsValues.Count && _bestSongsValues[_position] != null)
            {
                return true;
            }

            return false;
        }

        public SongInfo Next()
        {
            if (_bestSongsValues.Count > _position)
            {
                var next = _bestSongsValues[_position];
                _position++;

                return next;
            }

            return null;
        }

        public void RemoveSongInfo(SongInfo song)
        {
            //Logic to remove a songinfo
        }
    }
}
