namespace CommandPatternYT.Factory
{
    public class TvRemote
    {
        public static IElectronicDevice GetDevice()
        {
            return new Television();
        }
    }
}
