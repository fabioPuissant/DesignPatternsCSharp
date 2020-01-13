using StrategyPattern.QuackBehaviour;
using StrategyPattern.FlyBehaviour;

namespace StrategyPattern.Ducks
{
    public class RubberDucky : Duck
    {
        public RubberDucky()
        {
            Type = "Rubber";
            this.FlyBehaviour = new FlyNoWay();
            this.QuackBehaviour = new Squeek();
        }
    }
}
