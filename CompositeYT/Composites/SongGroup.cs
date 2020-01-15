using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeYT.Composites
{
    public class SongGroup : SongComponent
    {
        private IList<SongComponent> _songComponents;
        public string GroupName { get; }
        public string GroupDescription { get; }

        public SongGroup(string groupName, string groupDescription)
        {
            _songComponents = new List<SongComponent>();
            GroupName = groupName;
            GroupDescription = groupDescription;
        }

        public override void Add(SongComponent songComponent)
        {
            _songComponents.Add(songComponent);
        }

        public override void Remove(SongComponent songComponent)
        {
            _songComponents.Remove(songComponent);
        }

        public override SongComponent GetSongComponent(int index)
        {
            if (_songComponents.Count > index)
            {
                return _songComponents[index];
            }

            return null;
        }

        public override void Display()
        {
            Console.WriteLine($"\n{GroupName}: {GroupDescription}\n----------------------------");

            using var iterator = _songComponents.GetEnumerator();
            while (iterator.MoveNext())
            {
                iterator.Current?.Display();
            }
        }
    }
}
