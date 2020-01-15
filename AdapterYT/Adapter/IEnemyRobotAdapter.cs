using System;
using System.Collections.Generic;
using System.Text;
using AdapterYT.Adaptee;

namespace AdapterYT.Adapter
{
    public class EnemyRobotAdapter: IEnemyAttacker
    {
        private readonly EnemyRobot _enemyRobot;

        public EnemyRobotAdapter(EnemyRobot enemyRobot)
        {
            _enemyRobot = enemyRobot;
        }

        public void FireWeapon()
        {
            _enemyRobot.SmashWithHands();
        }

        public void MoveForward()
        {
            _enemyRobot.WalkForward();
        }

        public void AssignDriver(string driverName)
        {
            _enemyRobot.ReactToHuman(driverName);
        }
    }
}
