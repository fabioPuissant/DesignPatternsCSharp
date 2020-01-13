namespace CommandPatternYT.Commands
{
    public class TurnVolumeDown: ICommand
    {
        private readonly IElectronicDevice _electronicDevice;

        public TurnVolumeDown(IElectronicDevice electronicDevice)
        {
            _electronicDevice = electronicDevice;
        }
        public void Execute()
        {
            _electronicDevice.VolumeDown();
        }

        public void Undo()
        {
            _electronicDevice.VolumeUp();
        }
    }
}
