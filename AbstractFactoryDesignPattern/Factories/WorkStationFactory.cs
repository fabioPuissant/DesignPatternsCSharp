namespace AbstractFactoryDesignPattern.Factories
{
    public class WorkStationFactory: IComputerAbstractFactory
    {
        private readonly string _ram;
        private readonly string _hdd;
        private readonly string _cpu;

        public WorkStationFactory(string ram, string hdd, string cpu)
        {
            _ram = ram;
            _hdd = hdd;
            _cpu = cpu;
        }

        public Computer CreateComputer()
        {
            return new WorkStation(_ram, _hdd, _cpu);
        }
    }
}
