using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeYT.Clients
{
    public class DiscJockey
    {
        private SongComponent _songList;

        public DiscJockey(SongComponent songList)
        {
            _songList = songList;
        }

        public void PlaySongList()
        {
            _songList.Display();
        }
    }
}
