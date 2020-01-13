using System;

namespace CommandPattern.Receivers
{
    public class Light
    {
        private string _location;

        public Light(string location)
        {
            _location = location;
        }

        public void TurnOn()
        {
            Console.WriteLine("The light is ON");
        }

        public void TurnOff()
        {
            Console.WriteLine("The light is OFF");
        }
    }
}
