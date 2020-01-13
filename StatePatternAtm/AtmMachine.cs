namespace StatePatternAtm
{
    //Context class
    public class AtmMachine
    {
        ATMState _hasCard;
        ATMState _noCard;
        ATMState _hasCorrectPin;
        ATMState _atmOutOfMoney;

        ATMState _currentAtmState;

        public int CashInMachine = 2000;
        public bool CorrectPinEntered = false;

        public AtmMachine()
        {
            _hasCard = new HasCard(this);
            _noCard = new NoCard(this);
            _hasCorrectPin = new HasPin(this);
            _atmOutOfMoney = new NoCash(this);

            _currentAtmState = _noCard;

            if (CashInMachine < 0)
            {
                _currentAtmState = _atmOutOfMoney;
            }
        }

        public void SetATMState(ATMState newATMState)
        {
            _currentAtmState = newATMState;
        }

        public void SetCashInMachine(int newCashInMachineState)
        {
            CashInMachine = newCashInMachineState;
        }

        public void InsertCard()
        {
            _currentAtmState.InsertCard();
        }

        public void EjectCard()
        {
            _currentAtmState.EjectCard();
        }

        public void RequestCash(int cashToWithdraw)
        {
            _currentAtmState.RequestCash(cashToWithdraw);
        }

        public void InsertPin(int pinEntered)
        {
            _currentAtmState.InsertPin(pinEntered);
        }

        public ATMState GetYesCardState()
        {
            return _hasCard;
        }

        public ATMState GetNoCardState() { return _noCard; }

        public ATMState GetHasPin() { return _hasCorrectPin; }

        public ATMState GetNoCashState() { return _atmOutOfMoney; }
    }
}
