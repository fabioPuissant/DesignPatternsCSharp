using AbstractFactoryDesignPattern.Factories;

namespace AbstractFactoryDesignPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Toevoegen van nieuwe soort computer?
            // 1) maak domain model aan en implement Computer
            // 2) maak een factory voor dit nieuwe computer model aan en implementeer IComputerAbstractFactory
            // Voordeel = GEEN switch statements en OPEN-CLOSED principle
            Computer pc = ComputerFactory.CreateComputer(new PcFactory("16GB", "1TB", "i7 9th Gen"));
            Computer server = ComputerFactory.CreateComputer(new ServerFactory("64", "5TB", "i9 9th Gen"));
            Computer laptop = ComputerFactory.CreateComputer(new PcFactory("8GB", "254GB", "i5 7th Gen"));
        }
    }
}
