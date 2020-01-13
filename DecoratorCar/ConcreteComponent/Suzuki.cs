using DecoratorCar.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorCar.ConcreteComponent
{
    public class Suzuki : ICar
    {
        public string Make => "Suzuki car";

        public double GetPrice()
        {
            return 22000;
        }
    }
}
