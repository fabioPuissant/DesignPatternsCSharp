using StrategyPattern.FlyBehaviour;
using StrategyPattern.QuackBehaviour;


namespace StrategyPattern.Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            Type = "Mallard";
            FlyBehaviour = new FlyWithWings();
            QuackBehaviour = new BigQuack();
        }
    }
}
