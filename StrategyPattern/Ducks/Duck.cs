using StrategyPattern.FlyBehaviour;
using StrategyPattern.QuackBehaviour;
using System;


namespace StrategyPattern
{
    public class Duck
    {
        private string _type;
        public string Type { get => _type; set { _type = value; } }

        private IFlyBehaviour _flyBehaviour;
        public IFlyBehaviour FlyBehaviour { get => _flyBehaviour; set { _flyBehaviour = value; } }

        private IQuackBehaviour _quackBehaviour;
        public IQuackBehaviour QuackBehaviour { get => _quackBehaviour; set { _quackBehaviour = value; } }

        void Swim()
        {
            Console.WriteLine("Swimming");
        }

        public void Fly()
        {
            _flyBehaviour.Fly();
        }

        public void Quack()
        {
            _quackBehaviour.Quack();
        }

        public void Display()
        {
            Console.WriteLine($"This is the {Type} duck.");
            Fly();
            Quack();
        }
    }
}
