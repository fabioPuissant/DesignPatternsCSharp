using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.QuackBehaviour
{
    public class Squeek : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Sqeek, Sqeek");
        }
    }
}
