using System;
using CommandPattern.Commands;
using CommandPattern.Invokers;
using CommandPattern.Receivers;

namespace CommandPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
           RemoteControl remoteControl = new RemoteControl();

           Light livingRoomLight = new Light("Living Room");
           Light kitchenLight = new Light("Kitchen");
           CeilingFan ceilingFan = new CeilingFan("Living Room");
           GarageDoor garageDoor = new GarageDoor("");
           Stereo stereo = new Stereo("Living Room");

           LightOnCommand livingRoomLightOn =
               new LightOnCommand(livingRoomLight);
           LightOffCommand livingRoomLightOff =
               new LightOffCommand(livingRoomLight);
           LightOnCommand kitchenLightOn =
               new LightOnCommand(kitchenLight);
           LightOffCommand kitchenLightOff =
               new LightOffCommand(kitchenLight);

           CeilingFanOnCommand ceilingFanOn =
               new CeilingFanOnCommand(ceilingFan);
           CeilingFanOffCommand ceilingFanOff =
               new CeilingFanOffCommand(ceilingFan);

           GarageDoorUpCommand garageDoorUp =
               new GarageDoorUpCommand(garageDoor);
           GarageDoorDownCommand garageDoorDown =
               new GarageDoorDownCommand(garageDoor);

           StereoOnWithCDCommand stereoOnWithCD =
               new StereoOnWithCDCommand(stereo);
           StereoOffCommand stereoOff =
               new StereoOffCommand(stereo);

           remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
           remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
           remoteControl.SetCommand(2, ceilingFanOn, ceilingFanOff);
           remoteControl.SetCommand(3, stereoOnWithCD, stereoOff);

           Console.WriteLine(remoteControl);

           remoteControl.OnButtonPushed(0);
           remoteControl.OffButtonPushed(0);
           remoteControl.OnButtonPushed(1);
           remoteControl.OffButtonPushed(1);
           remoteControl.OnButtonPushed(2);
           remoteControl.OffButtonPushed(2);
           remoteControl.OnButtonPushed(3);
           remoteControl.OffButtonPushed(3);
		}
    }
}
