﻿using System;

namespace CommandPattern.Invokers
{
    public class Stereo
    {
        private string location;

        public Stereo(string location)
        {
            this.location = location;
        }

        public void On()
        {
            Console.WriteLine(location + " stereo is on");
        }

        public void Off()
        {
            Console.WriteLine(location + " stereo is off");
        }

        public void SetCd()
        {
            Console.WriteLine(location + " stereo is set for CD input");
        }

        public void SetDvd()
        {
            Console.WriteLine(location + " stereo is set for DVD input");
        }

        public void SetRadio()
        {
            Console.WriteLine(location + " stereo is set for Radio");
        }

        public void SetVolume(int volume)
        {
            // code to set the volume
            // valid range: 1-11 (after all 11 is better than 10, right?)
            Console.WriteLine(location + " Stereo volume set to " + volume);
        }
	}
}
