using System;

namespace StrategyPattern.FlyBehaviour
{
    public class FlyWithWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Flying with my wings");
        }
    }
}
