namespace CommandPatternYT.Commands
{
    public class TurnVolumeUp: ICommand
    {
        private readonly IElectronicDevice _electronicDevice;

        public TurnVolumeUp(IElectronicDevice electronicDevice)
        {
            _electronicDevice = electronicDevice;
        }
        public void Execute()
        {
            _electronicDevice.VolumeUp();
        }

        public void Undo()
        {
            _electronicDevice.VolumeDown();
        }
    }



}
