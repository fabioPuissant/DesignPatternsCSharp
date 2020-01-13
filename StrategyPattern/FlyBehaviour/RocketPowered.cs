using System;

namespace StrategyPattern.FlyBehaviour
{
    public class RocketPowered : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Rocket boosted fly behaviour");
        }
    }
}
