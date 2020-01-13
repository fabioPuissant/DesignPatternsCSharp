using System;

namespace CommandPatternYT
{
    public class Television: IElectronicDevice
    {
        private int _volume;

        public void TurnOn()
        {
            Console.WriteLine("The TV is ON");
        }

        public void TurnOff()
        {
            Console.WriteLine("The TV is OFF");
        }

        public void VolumeUp()
        {
            _volume++;
            Console.WriteLine($"The TV volume is at {_volume}");
        }

        public void VolumeDown()
        {
            _volume--;
            Console.WriteLine($"The TV volume is at {_volume}");
        }

    }
}
