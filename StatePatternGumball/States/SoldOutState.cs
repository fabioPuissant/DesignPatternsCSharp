using System;
using StatePatternGumball.Context;

namespace StatePatternGumball.States
{
    public class SoldOutState: IState
    {
        private readonly GumballMachineContext _gumballMachineContext;

        public SoldOutState(GumballMachineContext gumballMachineContext)
        {
            _gumballMachineContext = gumballMachineContext;
        }
        public void InsertQuarter()
        {
            throw new NotImplementedException();
        }

        public void EjectQuarter()
        {
            throw new NotImplementedException();
        }

        public void TurnCrank()
        {
            throw new NotImplementedException();
        }

        public void Dispense()
        {
            throw new NotImplementedException();
        }
    }
}
