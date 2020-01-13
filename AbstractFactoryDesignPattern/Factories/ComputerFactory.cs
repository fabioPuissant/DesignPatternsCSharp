using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Factories
{
    public class ComputerFactory
    {
        public static Computer CreateComputer(IComputerAbstractFactory factory)
        {
           return factory.CreateComputer();
        }
    }
}
