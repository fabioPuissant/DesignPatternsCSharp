using System;
using StateYT.Context;

namespace StateYT.States
{
    public class NoCard: IAtmState
    {
        private readonly AtmMachine _atmMachine;

        public NoCard(AtmMachine atmMachine) => _atmMachine = atmMachine;
        public void InsertCard()
        {
            Console.WriteLine("Card received!");
            _atmMachine.SetAtmState(_atmMachine.HasCard);
        }

        public void EjectCard()
        {
            Console.WriteLine("No Card In Machine To Eject!");
        }

        public void InsertPin(int pin)
        {
            Console.WriteLine("Please enter a card before giving your PIN!");
        }

        public void RequestCash(double amount)
        {
            Console.WriteLine("Cannot withdraw cash when no card in machine!");

        }
    }
}
