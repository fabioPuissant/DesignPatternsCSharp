namespace CommandPatternYT.Commands
{
    public class TurnTvOn: ICommand
    {
        private readonly IElectronicDevice _electronicDevice;

        public TurnTvOn(IElectronicDevice electronicDevice)
        {
            _electronicDevice = electronicDevice;
        }
        public void Execute()
        {
            _electronicDevice.TurnOn();
        }

        public void Undo()
        {
            _electronicDevice.TurnOff();
        }
    }
}
