using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Bevarages
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House Blend Coffee";
        }

        public override double Cost()
        {
            return .89;
        }
    }
}
