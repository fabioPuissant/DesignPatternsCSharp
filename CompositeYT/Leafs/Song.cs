using System;

namespace CompositeYT.Leafs
{
    public class Song : SongComponent
    {
        private string _songName;
        private string _bandName;
        private int _releaseYear;

        public Song(string songName, string bandName, int releaseYear)
        {
            _songName = songName;
            _bandName = bandName;
            _releaseYear = releaseYear;
        }

        public override string GetSongName()
        {
            return _songName;
        }

        public override string GetBandName()
        {
            return _bandName;
        }

        public override int GetReleaseYear()
        {
            return _releaseYear;
        }

        public override void Display()
        {
            Console.WriteLine($"{_songName} by {_bandName} in {_releaseYear}");
        }
    }
}
