﻿ using System;

 namespace CommandPattern.Invokers
{
    public class GarageDoor
    {
        private  string _location;

        public GarageDoor(string location)
        {
            this._location = location;
        }

        public void Up()
        {
            Console.WriteLine(_location + " garage Door is Up");
        }

        public void Down()
        {
            Console.WriteLine(_location + " garage Door is Down");
        }

        public void Stop()
        {
            Console.WriteLine(_location + " garage Door is Stopped");
        }

        public void LightOff()
        {
            Console.WriteLine(_location + " garage light is off");
        }
	}
}
