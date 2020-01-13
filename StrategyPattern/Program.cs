using System;
using System.Collections.Generic;
using StrategyPattern.Ducks;
using System.Linq;
using StrategyPattern.FlyBehaviour;

namespace StrategyPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Duck simulqtor [Strategy Pattern]");
            Console.WriteLine();

            IList<Duck> ducks = new List<Duck>();
            Duck mallardDuck = new MallardDuck();
            Duck rubberDuck = new RubberDucky();
            Duck dynamicDuck = new DynamicDuck();

            ducks.Add(mallardDuck);
            ducks.Add(rubberDuck);
            ducks.Add(dynamicDuck);

            Console.WriteLine("Before dynamic changed behaviour of dynamic duck.");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine();

            ducks.ToList().ForEach(d => {
                d.Display();
                Console.WriteLine();

            });

            Console.WriteLine();
            Console.WriteLine("################################################################");
            Console.WriteLine();
            Console.WriteLine();

            dynamicDuck.FlyBehaviour = new RocketPowered();

            Console.WriteLine("After dynamic changed behaviour of dynamic duck.");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine();

            ducks.ToList().ForEach(d => {
                d.Display();
                Console.WriteLine();

            });
        }
    }
}
