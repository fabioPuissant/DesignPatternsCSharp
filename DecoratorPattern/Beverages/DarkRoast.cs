using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Bevarages
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roast";
        }

        public override double Cost()
        {
            return .99;
        }
    }
}
