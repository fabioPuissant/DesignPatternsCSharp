using System;

namespace TemplateMethod
{
    public abstract class Hoagie
    {
        //Template method that encapsulates the 
        // Algoritm
        public void MakeSandwich()
        {
            CutBun();
            if (WantsMeat())
            {
                AddMeat();
            }

            if (WantsCheese())
            {
                AddCheese();
            }

            if (WantsVeggies())
            {
                AddVegetables();
            }

            if (WantsCondiments())
            {
                AddCondiments();
            }

            WrapHoagie();
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine();

        }

        public abstract void AddMeat();

        public abstract void AddCheese();

        public abstract void AddVegetables();
        public abstract void AddCondiments();

        public void CutBun()
        {
            Console.WriteLine("Cutting the bun");
        }

        public void WrapHoagie()
        {
            Console.WriteLine("Wrapping the Hoagie");
        }

        public virtual bool WantsMeat() { return true; }
        public virtual bool WantsVeggies() { return true; }
        public virtual bool WantsCheese() { return true; }
        public virtual bool WantsCondiments() { return true; }

    }
}
