using System;
using StatePatternGumball.States;

namespace StatePatternGumball.Context
{
    public class GumballMachineContext
    {
        public readonly IState SoldOut;
        public readonly IState NoQuarter;
        public readonly IState HasQuarter;
        public readonly IState Sold;
        public readonly IState Winner;

        private IState _state;
        public int Count;

        public GumballMachineContext(int numberOfGumballs)
        {
            SoldOut = new SoldOutState(this);
            NoQuarter = new NoQuarterState(this);
            HasQuarter = new HasQuarterState(this);
            Sold = new SoldState(this);
            Winner = new WinnerState(this);

            Count = numberOfGumballs;
            if (Count > 0)
            {
                _state = NoQuarter;
            }
        }

        public void InsertQuarter()
        {
            _state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            _state.EjectQuarter();
        }

        public void TurnCrank()
        {
            _state.TurnCrank();
            _state.Dispense();
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (Count != 0)
            {
                Count -=1;
            }
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public IState GetCurrentState()
        {
            return _state;
        }
    }
}