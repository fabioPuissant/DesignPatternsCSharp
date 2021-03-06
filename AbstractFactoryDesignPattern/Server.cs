﻿namespace AbstractFactoryDesignPattern
{
    public class Server : Computer
    {
        private string _ram;
        private string _hdd;
        private string _cpu;

        public Server(string ram, string hdd, string cpu)
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
            return _hdd;
        }

        public string GetCPU()
        {
            return _cpu;
        }
    }
}
