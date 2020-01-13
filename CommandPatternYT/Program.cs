using System;
using System.Collections.Generic;
using CommandPatternYT.Commands;
using CommandPatternYT.Factory;
using CommandPatternYT.Manager;

namespace CommandPatternYT
{
    public class Program
    {
        static void Main(string[] args)
        {
            IElectronicDevice device = TvRemote.GetDevice();

            TurnTvOn onCommand = new TurnTvOn(device);
            DeviceButton buttonOn = new DeviceButton(onCommand);
            buttonOn.PressButton();

            TurnTvOff offCommand = new TurnTvOff(device);
            DeviceButton buttonOff = new DeviceButton(offCommand);
            buttonOff.PressButton();

            ICommand volumeUpCommand = new TurnVolumeUp(device);
            DeviceButton buttonVolumeUp = new DeviceButton(volumeUpCommand);
            buttonVolumeUp.PressButton();
            buttonVolumeUp.PressButton();
            buttonVolumeUp.PressButton();

            ICommand volumeDownCommand = new TurnVolumeDown(device);
            DeviceButton buttonVolumeDown = new DeviceButton(volumeDownCommand);
            buttonVolumeDown.PressButton();

            // More than one
            Console.WriteLine("--------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("All devices turning off:");
            Console.WriteLine("");
            Television tv = new Television();
            Radio radio = new Radio();
            IList<IElectronicDevice> devices = new List<IElectronicDevice>
            {
                tv, radio
            };

            ICommand turnAllOff = new TurnItAllOff(devices);
            DeviceButton allOffButton = new DeviceButton(turnAllOff);
            allOffButton.PressButton();

            // More than one
            Console.WriteLine("--------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("All devices turning on by Undo():");
            Console.WriteLine("");
            allOffButton.PressUndo();
        }
    }
}
