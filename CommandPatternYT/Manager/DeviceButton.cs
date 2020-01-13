using CommandPatternYT.Commands;

namespace CommandPatternYT.Manager
{
    internal class DeviceButton
    {
        private readonly ICommand _command;

        public DeviceButton(ICommand command)
        {
            _command = command;
        }

        public void PressButton()
        {
            _command.Execute();
        }

        public void PressUndo()
        {
            _command.Undo();
        }
    }
}