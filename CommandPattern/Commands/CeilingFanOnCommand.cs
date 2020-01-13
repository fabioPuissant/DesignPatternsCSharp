using System;
using System.Collections.Generic;
using System.Text;
using CommandPattern.Invokers;

namespace CommandPattern.Commands
{
    public class CeilingFanOnCommand: ICommand
    {
        CeilingFan ceilingFan;

        public CeilingFanOnCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }
        public void Execute() => ceilingFan.High();
        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
