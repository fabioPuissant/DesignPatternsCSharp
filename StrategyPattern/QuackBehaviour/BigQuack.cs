using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.QuackBehaviour
{
    public class BigQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("QUACK QUACK");
        }
    }
}
