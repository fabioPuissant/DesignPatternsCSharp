using DecoratorPattern.Bevarages;

namespace DecoratorPattern.Decoraters
{
    public class Mocha : CondimentDecorater
    {
        private readonly Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            this._beverage = beverage;
        }
        public override double Cost()
        {
            return _beverage.Cost() + 0.20;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Mocha";
        }
    }
}
