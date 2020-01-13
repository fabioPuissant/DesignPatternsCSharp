using DecoratorCar.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorCar.ConcreteComponent
{
    public sealed class Hyndai : ICar
    {
        public string Make => "Hyundai car";

        public double GetPrice() => 80000.0;
    }
}
