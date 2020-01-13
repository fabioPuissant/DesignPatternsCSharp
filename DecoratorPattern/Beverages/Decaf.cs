using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Bevarages
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf";
        }

        public override double Cost()
        {
            return .80;
        }
    }
}
