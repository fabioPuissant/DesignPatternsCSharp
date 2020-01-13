using System;
using StatePatternGumball.Context;

namespace StatePatternGumball.States
{
    public class HasQuarterState : IState
    {
        private Random _randomWinner = new Random(DateTime.Now.Millisecond);
        private readonly GumballMachineContext _context;

        public HasQuarterState(GumballMachineContext context)
        {
            _context = context;
        }
        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter ejected");
            _context.SetState(_context.NoQuarter);
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            int winner = _randomWinner.Next(10);
            if (winner == 0 && _context.Count > 1)
            {
                _context.SetState(_context.Winner);
                return;
            }

            _context.SetState(_context.Sold);
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }
    }
}
