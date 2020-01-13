using System;

namespace StatePatternAtm
{
    internal class HasPin : ATMState
    {
        private AtmMachine _atmMachine;

        public HasPin(AtmMachine atmMachine)
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
            Console.WriteLine("You Can't Insert More Than One Card");
        }

        public void InsertPin(int pinEntered)
        {
            Console.WriteLine("Already Entered Correct PIN");
        }

        public void RequestCash(int cashToWithdraw)
        {
            if(cashToWithdraw > _atmMachine.CashInMachine)
            {
                Console.WriteLine("Don't Have That Cash");
                Console.WriteLine("Card Ejected");
                _atmMachine.SetATMState(_atmMachine.GetNoCardState());
                return;
            }


            Console.WriteLine($"{cashToWithdraw} Is Provided By The Machine");
            _atmMachine.SetCashInMachine(_atmMachine.CashInMachine - cashToWithdraw);

            Console.WriteLine("Card Ejected");
            _atmMachine.SetATMState(_atmMachine.GetNoCardState());
            
            if(_atmMachine.CashInMachine <= 0)
            {
                _atmMachine.SetATMState(_atmMachine.GetNoCashState());
            }
        }
    }
}