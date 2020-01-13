using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Factories
{
    public class PcFactory : IComputerAbstractFactory
    {
        private string _ram;
        private string _hdd;
        private string _cpu;

        public PcFactory(string ram, string hdd, string cpu)
        {
            _ram = ram;
            _hdd = hdd;
            _cpu = cpu;
        }

        public Computer CreateComputer()
        {
            return new Pc(_ram, _hdd, _cpu);
        }

    }
}
