using System;
using System.Linq;

namespace TemplateMethod
{
    public class ItalianHoagie : Hoagie
    {
        private string[] _meatsUsed = { "Salami", "Peperoni", "Capacoli Ham" };
        private string[] _cheeseUsed = { "Provolone" };
        private string[] _veggiesUsed = { "Lettuce", "Tomatoes", "Onions", "Sweet Pepper" };
        private string[] _condimentsUsed = { "Oil", "Vinegar" };
        public override void AddCheese()
        {
            Console.Write("Adding the Cheese: ");

            _cheeseUsed.ToList().ForEach(c => Console.Write(c + " "));
            Console.WriteLine();
        }

        public override void AddCondiments()
        {
            Console.Write("Adding the Condinments: ");

            _condimentsUsed.ToList().ForEach(c => Console.Write(c + " "));
            Console.WriteLine();
        }

        public override void AddMeat()
        {
            Console.Write("Adding the Meat: ");

            _meatsUsed.ToList().ForEach (m => Console.Write(m + " ")) ;
            Console.WriteLine();
        }

        public override void AddVegetables()
        {
            Console.Write("Adding the Veggies: ");
            _veggiesUsed.ToList().ForEach(v => Console.Write(v + " "));
            Console.WriteLine();
        }
    }
}
