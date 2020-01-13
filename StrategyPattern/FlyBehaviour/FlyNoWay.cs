using System;


namespace StrategyPattern.FlyBehaviour
{
    public class FlyNoWay : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly...");
        }
    }
}
