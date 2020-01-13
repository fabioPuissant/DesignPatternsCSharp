using DecoratorPattern.Bevarages;

namespace DecoratorPattern.Decoraters
{
    public abstract class CondimentDecorater : Beverage
    {
        public override abstract string GetDescription();
    }
}
