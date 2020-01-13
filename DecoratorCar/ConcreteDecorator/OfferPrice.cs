using DecoratorCar.Component;
using DecoratorCar.Decorator;

namespace DecoratorCar.ConcreteDecorator
{
    public class OfferPrice : CarDecorator
    {
        public OfferPrice(ICar car): base(car)
        {

        }

        public override double GetDiscountedPrice()
        {
            return .8 * GetPrice();
        }
    }
}
