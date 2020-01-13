using DecoratorPattern.Bevarages;

namespace DecoratorPattern.Decoraters
{
    public class Whip : CondimentDecorater
    {
        private readonly Beverage _beverage;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override double Cost()
        {
            return _beverage.Cost() + .10;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Whip";
        }
    }
}
