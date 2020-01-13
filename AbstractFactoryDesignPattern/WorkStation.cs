using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    public class WorkStation: Computer
    {
        private readonly string _ram;
        private readonly string _hdd;
        private readonly string _cpu;

        public WorkStation(string ram, string hdd, string cpu)
        {
            _ram = ram;
            _hdd = hdd;
            _cpu = cpu;
        }
        public string GetRAM()
        {
            return _ram;
        }

        public string GetHDD()
        {
            return _ram;
        }

        public string GetCPU()
        {
            return _ram;
        }
    }
}
