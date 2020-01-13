using System.Collections.Generic;
using System.Linq;

namespace CommandPatternYT.Commands
{
    public class TurnItAllOff : ICommand
    {
        private IList<IElectronicDevice> _devices;

        public TurnItAllOff(IList<IElectronicDevice> devices)
        {
            _devices = devices;
        }

        public void Execute()
        {
            _devices.ToList()
                .ForEach(d => d.TurnOff());
        }

        public void Undo()
        {
            _devices.ToList()
                .ForEach(d => d.TurnOn());
        }
    }
}
