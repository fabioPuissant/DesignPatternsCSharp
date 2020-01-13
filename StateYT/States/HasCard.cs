using System;

using StateYT.Context;

namespace StateYT.States
{
    public class HasCard : IAtmState
    {
        private readonly AtmMachine _atmMachine;
        private const int CORRECTPIN = 1207;
        public HasCard(AtmMachine atmMachine) => _atmMachine = atmMachine;
        public void InsertCard()
        {
            Console.WriteLine("You already have a card inserted, can only handle one card!");
        }

        public void EjectCard()
        {
            Console.WriteLine("Card Ejected!");
            _atmMachine.SetAtmState(_atmMachine.NoCard);
        }

        public void InsertPin(int pin)
        {
            if (pin == CORRECTPIN)
            {
                Console.WriteLine("PIN Correct!");
                _atmMachine.SetAtmState(_atmMachine.HasCorrectPin);
                _atmMachine.PinCorrectEntered = true;
                return;
            }

            Console.WriteLine("PIN NOT Correct!");
            _atmMachine.PinCorrectEntered = false;

            Console.WriteLine("Card Ejected!");
            _atmMachine.SetAtmState(_atmMachine.NoCard);
        }

        public void RequestCash(double amount)
        {
            Console.WriteLine("Enter PIN First!");

        }
    }
}
