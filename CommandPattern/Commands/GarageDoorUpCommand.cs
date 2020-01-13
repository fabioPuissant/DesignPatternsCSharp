using System;
using CommandPattern.Invokers;

namespace CommandPattern.Commands
{
    internal class GarageDoorUpCommand : ICommand
    {
        readonly GarageDoor _garageDoor;

        public GarageDoorUpCommand(GarageDoor garageDoor)
        {
            this._garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.Up();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}