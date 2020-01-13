using System;
using StatePatternGumball.Context;

namespace StatePatternGumball.States
{

    public class SoldState: IState
    {

        private readonly GumballMachineContext _context;

        public SoldState(GumballMachineContext gumballMachine)
        {
            _context = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we already giving you a Gumball");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't give you another gumball!");
        }

        public void Dispense()
        {
            _context.ReleaseBall();
            if (_context.Count > 0)
            {
                _context.SetState(_context.NoQuarter);
                return;
            }

            Console.WriteLine("Oops out of gumballs");
            _context.SetState(_context.SoldOut);
        }
    }
}
