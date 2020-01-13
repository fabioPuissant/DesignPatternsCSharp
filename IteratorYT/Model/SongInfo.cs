using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorYT.Model
{
    public class SongInfo
    {
        private readonly string _newSongName;
        public string SongName => _newSongName;

        private readonly string _newBandName;
        public string BandName => _newBandName;

        private readonly int _yearReleased;
        public int YearReleased => _yearReleased;

        public SongInfo(string newSongName, string newBandName, int yearReleased )
        {
            _newSongName = newSongName;
            _newBandName = newBandName;
            _yearReleased = yearReleased;
        }

        public override string ToString()
        {
            return $"{SongName} by {_newBandName} in {_yearReleased}";
        }
    }
}
