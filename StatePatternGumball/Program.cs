using StatePatternGumball.Context;

namespace StatePatternGumball
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GumballMachineContext gumballMachine = new GumballMachineContext(5);
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

           

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
        }
    }
}
