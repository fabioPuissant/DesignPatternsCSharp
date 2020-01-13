using System;

namespace StrategyPattern.QuackBehaviour
{
    public class NoSound : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("I make no sound...");
        }
    }
}
