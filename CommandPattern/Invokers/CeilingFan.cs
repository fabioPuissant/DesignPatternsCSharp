using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Invokers
{
    public class CeilingFan
    {
        readonly string _location = "";
        int _level;
        public const int HIGH = 2;
        public const int MEDIUM = 1;
        public const int LOW = 0;

        public CeilingFan(String location)
        {
            this._location = location;
        }

        public void High()
        {
            // turns the ceiling fan on to high
            _level = HIGH;
            Console.WriteLine(_location + " ceiling fan is on high");

        }

        public void Medium()
        {
            // turns the ceiling fan on to medium
            _level = MEDIUM;
            Console.WriteLine(_location + " ceiling fan is on medium");
        }

        public void Low()
        {
            // turns the ceiling fan on to low
            _level = LOW;
            Console.WriteLine(_location + " ceiling fan is on low");
        }

        public void Off()
        {
            // turns the ceiling fan off
            _level = 0;
            Console.WriteLine(_location + " ceiling fan is off");
        }

        public int GetSpeed()
        {
            return _level;
        }
	}
}
