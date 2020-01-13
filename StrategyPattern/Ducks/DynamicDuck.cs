using StrategyPattern.FlyBehaviour;
using StrategyPattern.QuackBehaviour;


namespace StrategyPattern.Ducks
{
    public class DynamicDuck : Duck
    {
        public DynamicDuck()
        {
            Type = "Dynamic";
            FlyBehaviour = new FlyNoWay();
            QuackBehaviour = new NoSound();
        }
    }
}
