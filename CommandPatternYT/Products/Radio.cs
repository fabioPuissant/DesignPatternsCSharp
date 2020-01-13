using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternYT
{
    public class Radio : IElectronicDevice
    {
        private int _volume;
        public void TurnOn()
        {
            Console.WriteLine("Radio is ON");
        }

        public void TurnOff()
        {
            Console.WriteLine("Radio is OFF");
        }

        public void VolumeUp()
        {
            _volume++;
            Console.WriteLine($"Radio volume is at {_volume}");
        }

        public void VolumeDown()
        {
            _volume--;
            Console.WriteLine($"Radio volume is at {_volume}");
        }
    }
}
