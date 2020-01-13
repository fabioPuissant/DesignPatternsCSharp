using StateYT.States;

namespace StateYT.Context
{
    public class AtmMachine
    {
        public readonly IAtmState HasCard;
        public readonly IAtmState NoCard;
        public readonly IAtmState HasCorrectPin;
        public readonly IAtmState OutOfMoney;

        private IAtmState _currentState;

        private double _cashInMachine = 2000;
        public double CashInMachine => _cashInMachine;
        public bool PinCorrectEntered = false;

        public AtmMachine()
        {
            HasCard = new HasCard(this);
            NoCard = new NoCard(this);
            HasCorrectPin = new HasPin(this);
            OutOfMoney = new NoCash(this);

            _currentState = NoCard;

            if (_cashInMachine < 0)
            {
                _currentState = OutOfMoney;
            }
        }

        public void SetAtmState(IAtmState newState)
        {
            _currentState = newState;
        }

        public void SetCashInMachine(double newCachInMachineAmount)
        {
            _cashInMachine = newCachInMachineAmount;
        }


        public void InsertCard()
        {
            _currentState.InsertCard();
        }

        public void EjectCard()
        {
            _currentState.EjectCard();
        }

        public void InsertPin(int pin)
        {
            _currentState.InsertPin(pin);
        }

        public void RequestCash(double amount)
        {
            _currentState.RequestCash(amount);
        }
    }
}
