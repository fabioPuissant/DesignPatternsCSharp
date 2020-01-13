using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternAtm
{
   public  interface ATMState
    {
        void InsertCard();
        void EjectCard();
        void InsertPin(int pinEntered);
        void RequestCash(int cashToWithdraw);
    }
}
