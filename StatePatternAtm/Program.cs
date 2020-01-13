using System;

namespace StatePatternAtm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AtmMachine machine = new AtmMachine();

            machine.InsertCard();

            machine.EjectCard();

            machine.InsertCard();

            machine.InsertPin(1234);

            machine.RequestCash(2000);

            machine.InsertCard();

            machine.InsertPin(1234);
        }
    }
}
