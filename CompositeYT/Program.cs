using System;
using CompositeYT.Clients;
using CompositeYT.Composites;
using CompositeYT.Leafs;


namespace CompositeYT
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SongComponent industrialMusic = new SongGroup("Industrial", "List with Industrial songs");
            SongComponent metalMusic = new SongGroup("Metal", "List with Metal songs");
            SongComponent dubStepMusic = new SongGroup("DubStep", "List with DubStep songs");

            SongComponent everySong = new SongGroup("Every Song", "The complete song list of the DJ.");

            // Extending the DJ Playlist
            everySong.Add(industrialMusic);
            everySong.Add(metalMusic);
            everySong.Add(dubStepMusic);

            //Adding Songs to the Industrial genre
            industrialMusic.Add(new Song("Head like a hole", "NIN", 1990));
            industrialMusic.Add(new Song("Head Hunter", "Front 242", 1988));

            // Another group that is a sub group of industrial music
            industrialMusic.Add(dubStepMusic);

            //Adding Songs to the DubStep genre
            dubStepMusic.Add(new Song("Centipede", "Knife Party", 2012));
            dubStepMusic.Add(new Song("Tetris", "Doctor P", 2011));
            dubStepMusic.Add(new Song("Bangarang", "Skrillex", 2011));

            //Adding Songs to the Metal genre
            metalMusic.Add(new Song("War Pigs", "Black Sabbath", 1970));
            metalMusic.Add(new Song("Ace of Spades", "Motor Head", 1980));

            DiscJockey crazyLarry = new DiscJockey(everySong);
            crazyLarry.PlaySongList();
        }
    }
}
