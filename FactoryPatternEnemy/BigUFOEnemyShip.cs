using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternEnemy
{
    public class BigUFOEnemyShip : UFOEnemyShip
    {
        public BigUFOEnemyShip()
        {
            Name = "BIGGG UFO Enemy Ship";
            Damage = 40.0;
        }
    }
}
