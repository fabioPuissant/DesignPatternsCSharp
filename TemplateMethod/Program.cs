using System;

namespace TemplateMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hoagie customer12 = new ItalianHoagie();
            customer12.MakeSandwich();

            Hoagie customer13 = new VeggieHoagie();
            customer13.MakeSandwich();
        }
    }
}
