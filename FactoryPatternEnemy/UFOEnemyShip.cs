using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternEnemy
{
    public class UFOEnemyShip : EnemyShip
    {
        public UFOEnemyShip()
        {
            Name = "UFO Enemy Ship";
            Damage = 20.0;
        }
    }
}
