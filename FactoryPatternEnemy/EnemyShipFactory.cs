using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternEnemy
{
    public class EnemyShipFactory
    {
        public EnemyShip MakeEnenmyShip(string type)
        {
            switch (type.ToLower())
            {
                case "u": return new UFOEnemyShip();
                case "b": return new BigUFOEnemyShip();
                default: return new RocketEnemyShip();
            }
        }
    }
}
