using CommandPattern.Invokers;

namespace CommandPattern.Commands
{
    public class GarageDoorDownCommand:ICommand
    {
        readonly GarageDoor _garageDoor;

        public GarageDoorDownCommand(GarageDoor garageDoor)
        {
            this._garageDoor = garageDoor;
        }

        public void Execute() => _garageDoor.Down();
        public void Undo() => _garageDoor.Up();

    }
}
