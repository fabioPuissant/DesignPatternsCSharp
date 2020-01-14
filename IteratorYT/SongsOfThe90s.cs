using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using IteratorYT.Iterators;
using IteratorYT.Model;

namespace IteratorYT
{
    public class SongsOfThe90s: ISongIteratorCreator
    {
        int hashkey;
        private Dictionary<int, SongInfo> _bestSongs;
        

        public SongsOfThe90s()
        {
            _bestSongs = new Dictionary<int, SongInfo>();

            AddSong("Losing my Religion", "REM", 1991);
            AddSong("Creep", "Radiohead", 1993);
            AddSong("Walking on the ocean", "Toad the wet sprocket", 1991);
        }


        private void AddSong(string songName, string bandName, int releaseYear)
        {
            _bestSongs.Add(hashkey, new SongInfo(songName, bandName, releaseYear));
            hashkey++;
        }

        public ISongIterator CreateIterator()
        {
            return new Song90sIterator(_bestSongs);
        }
    }
}
