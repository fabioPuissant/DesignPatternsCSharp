
namespace DecoratorPattern.Bevarages
{
    public abstract class Beverage
    {
        protected string description;

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double Cost();
    }
}
