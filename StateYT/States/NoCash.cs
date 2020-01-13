using System;
using System.Collections.Generic;
using System.Text;
using StateYT.Context;

namespace StateYT.States
{
    public class NoCash: IAtmState
    {
        private readonly AtmMachine _atmMachine;

        public NoCash(AtmMachine atmMachine)
        {
            _atmMachine = atmMachine;
        }
        public void InsertCard()
        {
            Console.WriteLine("No Cash in this machine!");
        }

        public void EjectCard()
        {
            Console.WriteLine("No Cash in this machine! You didn't entered a card!");
        }

        public void InsertPin(int pin)
        {
            Console.WriteLine("No Cash in this machine! There is no card in the machine!");
        }

        public void RequestCash(double amount)
        {
            Console.WriteLine("Machine out of cash");
        }
    }
}
