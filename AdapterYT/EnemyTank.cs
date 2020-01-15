using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterYT
{
    public class EnemyTank : IEnemyAttacker
    {
        Random genartor = new Random();
        public void FireWeapon()
        {
            int attack = genartor.Next(10);
            Console.WriteLine($"Tank does {attack} damage.");
        }

        public void MoveForward()
        {
            int steps = genartor.Next(5);
            Console.WriteLine($"Tank moves {steps} steps forward.");

        }

        public void AssignDriver(string driverName)
        {
            Console.WriteLine($"{driverName} is driving the tank.");

        }
    }
}
