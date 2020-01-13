using DecoratorCar.Component;
using System;


namespace DecoratorCar.Decorator
{
    public abstract class CarDecorator : ICar
    {
        private readonly ICar _car;

        public CarDecorator(ICar car) => _car = car;

        public string Make => _car.Make;

        public double GetPrice()
        {
            return _car.GetPrice();
        }

        public abstract double GetDiscountedPrice();
    }
}
