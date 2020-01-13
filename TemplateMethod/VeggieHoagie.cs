using System;
using System.Linq;

namespace TemplateMethod
{
    public class VeggieHoagie : Hoagie
    {
        private string[] _veggiesUsed = { "Lettuce", "Tomatoes", "Onions", "Sweet Pepper" };
        private string[] _condimentsUsed = { "Oil", "Vinegar" };
        public override void AddCheese()
        {
            //Does nothing
        }

        public override void AddCondiments()
        {
            Console.Write("Adding the Condinments: ");

            _condimentsUsed.ToList().ForEach(c => Console.Write(c + " "));
            Console.WriteLine();
        }

        public override void AddMeat()
        {
            // Does nothing...
        }

        public override void AddVegetables()
        {
            Console.Write("Adding the Veggies: ");
            _veggiesUsed.ToList().ForEach(v => Console.Write(v + " "));
            Console.WriteLine();
        }

        public override bool WantsMeat() { return false; }
        public override bool WantsCheese()
        {
            return false;
        }
    }
}
