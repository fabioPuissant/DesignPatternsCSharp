﻿using System;
using System.Collections.Generic;
using System.Text;
using CommandPattern.Invokers;

namespace CommandPattern.Commands
{
    public class StereoOnWithCDCommand: ICommand
    {
        private Stereo _stereo;

        public StereoOnWithCDCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.On();
            _stereo.SetCd();
            _stereo.SetVolume(11);
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
