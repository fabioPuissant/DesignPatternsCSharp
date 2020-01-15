using CompositeYT.Exceptions;

namespace CompositeYT
{
    public abstract class SongComponent
    {
        // Subclasses should implement the methods they need
        // Some methods will be implemented by a Leaf, others by a Composite
        // Some methods will need to be implemented by both...
        // In this abstract class we will implement a default behaviour for the methods of this hierarchie
        public virtual void Add(SongComponent songComponent)
        {
            throw new UnsupportedMethodException();
        }

        public virtual void Remove(SongComponent songComponent)
        {
            throw new UnsupportedMethodException();
        }

        public virtual SongComponent GetSongComponent(int index)
        {
            throw new UnsupportedMethodException();
        }

        public virtual string GetSongName()
        {
            throw new UnsupportedMethodException();
        }

        public virtual string GetBandName()
        {
            throw new UnsupportedMethodException();
        }

        public virtual int GetReleaseYear()
        {
            throw new UnsupportedMethodException();
        }

        public virtual void Display()
        {
            throw new UnsupportedMethodException();
        }
    }
}
