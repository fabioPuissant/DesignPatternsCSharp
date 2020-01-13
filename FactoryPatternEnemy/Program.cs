using System;
using System.Linq;

namespace FactoryPatternEnemy
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which enemy ship should we use? B, R or U?");
            string input = Console.ReadLine();
            string[] possibilities = {"b","r","u"};


            if (possibilities.Contains(input.ToLower()))
            {
                EnemyShip ship = new EnemyShipFactory().MakeEnenmyShip(input);
                DoEnemyShipStuff(ship);
            }
        }

        private static void DoEnemyShipStuff(EnemyShip ship)
        {
            ship.DisplayEnemyShip();
            ship.FollowHeroShip();
            ship.EnemyShipShoots();
        }
    }
}
