using System;
using System.Collections.Generic;
using System.Text;
using CommandPattern.Invokers;

namespace CommandPattern.Commands
{
    public class CeilingFanOffCommand:ICommand
    {
        CeilingFan ceilingFan;

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }
        public void Execute()
        {
            ceilingFan.Off();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
