using System;
using StatePatternGumball.Context;

namespace StatePatternGumball.States
{
    public class NoQuarterState: IState
    {
        private readonly GumballMachineContext _context;

        public NoQuarterState(GumballMachineContext gumballMachineContext)
        {
            _context = gumballMachineContext;
        }
        public void InsertQuarter()
        {
            Console.WriteLine("Inserted a quarter, you can now turn the crank");
            _context.SetState(_context.HasQuarter);
        }

        public void EjectQuarter()
        {
            Console.WriteLine("No quarter to eject");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You must first insert a quarter in order to turn the crank!");

        }

        public void Dispense()
        {
            Console.WriteLine("NO quarter = NO gumball");
        }
    }
}
