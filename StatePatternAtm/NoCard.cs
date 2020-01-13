using System;

namespace StatePatternAtm
{
    internal class NoCard : ATMState
    {
        private AtmMachine _atmMachine;

        public NoCard(AtmMachine atmMachine)
        {
            this._atmMachine = atmMachine;
        }

        public void EjectCard()
        {
            Console.WriteLine("Enter Card First");
        }

        public void InsertCard()
        {
            Console.WriteLine("Please Enter Your PIN");
            _atmMachine.SetATMState(_atmMachine.GetYesCardState());
        }

        public void InsertPin(int pinEntered)
        {
            Console.WriteLine("Enter Card First");
        }

        public void RequestCash(int cashToWithdraw)
        {
            Console.WriteLine("Enter Card First");

        }
    }
}