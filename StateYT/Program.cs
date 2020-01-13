using System;
using StateYT.Context;

namespace StateYT
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AtmMachine atm = new AtmMachine();
            // No good use
            atm.InsertPin(1207);
            atm.EjectCard();
            atm.RequestCash(2000);

            //Good use
            atm.InsertCard();
            atm.EjectCard();

            atm.InsertCard();
            atm.InsertPin(1207);
            atm.RequestCash(2000);

            atm.InsertCard();
        }
    }
}
