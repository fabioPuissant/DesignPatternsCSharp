using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternEnemy
{
    public abstract class EnemyShip
    {
        public string Name { get; set; }
        public double Damage { get; set; }

        public void DisplayEnemyShip()
        {
            Console.WriteLine($"{Name} is on the screen");
        }

        public void FollowHeroShip()
        {
            Console.WriteLine($"{Name} is following the hero");
        }

        public void EnemyShipShoots()
        {
            Console.WriteLine($"{Name} attacks and does {Damage}.");
        }
    }
}
