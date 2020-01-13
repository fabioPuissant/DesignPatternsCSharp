using DecoratorCar.Component;
using DecoratorCar.ConcreteComponent;
using DecoratorCar.ConcreteDecorator;
using DecoratorCar.Decorator;
using System;

namespace DecoratorCar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ICar suzuki = new Suzuki();
            CarDecorator decorator = new OfferPrice(suzuki);

            Console.WriteLine($"Make: {decorator.Make}, Price: {decorator.GetPrice()}, DiscountPrice: {decorator.GetDiscountedPrice()}");
            Console.ReadLine();
        }
    }
}
