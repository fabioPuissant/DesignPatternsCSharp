using System;
using System.Collections.Generic;
using System.Text;

namespace StateYT.States
{
   public interface IAtmState
   {
       public void InsertCard();
       public void EjectCard();
       public void InsertPin(int pin);
       public void RequestCash(double amount);
   }
}
