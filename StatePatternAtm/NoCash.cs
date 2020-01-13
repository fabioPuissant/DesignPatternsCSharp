using System;

namespace StatePatternAtm
{
    internal class NoCash : ATMState
    {
        private AtmMachine _atmMachine;

        public NoCash(AtmMachine atmMachine)
        {
            _atmMachine = atmMachine;
        }

        public void EjectCard()
        {
            Console.WriteLine("We Don't Have Money. You didn't enter a card");
        }

        public void InsertCard()
        {
            Console.WriteLine("We Don't Have Money.");
        }

        public void InsertPin(int pinEntered)
        {
            Console.WriteLine("We Don't Have Money.");
        }

        public void RequestCash(int cashToWithdraw)
        {
            Console.WriteLine("We Don't Have Money.");
        }
    }
}