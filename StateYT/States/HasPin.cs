using System;
using System.Collections.Generic;
using System.Text;
using StateYT.Context;

namespace StateYT.States
{
    public class HasPin : IAtmState
    {
        private readonly AtmMachine _atmMachine;

        public HasPin(AtmMachine atmMachine)
        {
            _atmMachine = atmMachine;
        }

        public void InsertCard()
        {
            Console.WriteLine("Already have a card, please enter your PIN!");
        }

        public void EjectCard()
        {
            Console.WriteLine("Ejecting Card!");
            _atmMachine.SetAtmState(_atmMachine.NoCard);
        }

        public void InsertPin(int pin)
        {
            Console.WriteLine("Already Entered a PIN!");
        }

        public void RequestCash(double amount)
        {
            var currentAmount = _atmMachine.CashInMachine;
            if (currentAmount >= amount)
            {
                Console.WriteLine($"Getting ${amount}");
                var newAmount = currentAmount - amount;
                _atmMachine.SetCashInMachine(newAmount);

                EjectCard();

                if (newAmount == 0)
                {
                    Console.WriteLine("Machine is out of money");
                    _atmMachine.SetAtmState(_atmMachine.OutOfMoney);
                }
            }
        }
    }
}
