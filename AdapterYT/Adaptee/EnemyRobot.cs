using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterYT.Adaptee
{
    public class EnemyRobot
    {
        Random generator = new Random(DateTime.Now.Millisecond);

        public void SmashWithHands()
        {
            int damage = generator.Next(10);
            Console.WriteLine($"Enemy robot does {damage} damage with it's hands.");
        }

        public void WalkForward()
        {
            int movement = generator.Next(5);
            Console.WriteLine($"Enemy robot walks {movement} steps with it's feet");
        }

        public void ReactToHuman(string humanName)
        {
            Console.WriteLine($"Enemy robot tramps on {humanName}.");
        }
    }
}
