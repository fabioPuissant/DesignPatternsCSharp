using DecoratorPattern.Bevarages;
namespace DecoratorPattern.Decoraters
{
    public class Soy : CondimentDecorater
    {
        private readonly Beverage _beverage;

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override double Cost()
        {
            return _beverage.Cost() + .15;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Soy";
        }
    }
}
