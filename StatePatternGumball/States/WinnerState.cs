using System;
using StatePatternGumball.Context;

namespace StatePatternGumball.States
{
    public class WinnerState: IState
    {
        private readonly GumballMachineContext _context;

        public WinnerState(GumballMachineContext context)
        {
            _context = context;
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
            if (_context.Count == 0)
            {
                _context.SetState(_context.SoldOut);
            }
            else
            {
                _context.ReleaseBall();
                Console.WriteLine("You are a winner! you got two two gumballs for a quarter");
                if (_context.Count > 0)
                {
                    _context.SetState(_context.NoQuarter);
                }
                else
                {
                    Console.WriteLine("OOPS, out of Gumballs!");
                    _context.SetState(_context.SoldOut);
                }
            }
        }
    }
}
