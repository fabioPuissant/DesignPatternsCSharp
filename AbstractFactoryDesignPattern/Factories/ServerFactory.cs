using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Factories
{
    public class ServerFactory: IComputerAbstractFactory
    {
        private string _ram;
        private string _hdd;
        private string _cpu;

        public ServerFactory(string ram, string hdd, string cpu)
        {
            _ram = ram;
            _hdd = hdd;
            _cpu = cpu;
        }

        public Computer CreateComputer()
        {
            return new Server(_ram, _hdd, _cpu);
        }
    }
}
