using System;

namespace StatePatternAtm
{
    internal class HasCard : ATMState
    {
        private AtmMachine _atmMachine;

        public HasCard(AtmMachine atmMachine)
        {
            _atmMachine = atmMachine;
        }

        public void EjectCard()
        {
            Console.WriteLine("Card Ejected");
            _atmMachine.SetATMState(_atmMachine.GetNoCardState());
        }

        public void InsertCard()
        {
            Console.WriteLine("You can't enter more than one card.");
        }

        public void InsertPin(int pinEntered)
        {
            if (pinEntered == 1234)
            {
                Console.WriteLine("Correct PIN");
                _atmMachine.CorrectPinEntered = true;
                _atmMachine.SetATMState(_atmMachine.GetHasPin());
                return;
            }

            Console.WriteLine("Wrong PIN");
            _atmMachine.CorrectPinEntered = false;
            Console.WriteLine("Card Ejected");
            _atmMachine.SetATMState(_atmMachine.GetNoCardState());

        }

        public void RequestCash(int cashToWithdraw)
        {
            Console.WriteLine("Enter PIN First");
        }
    }
}