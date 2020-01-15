using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterYT
{
    public interface IEnemyAttacker
    {
        public void FireWeapon();
        public void MoveForward();
        public void AssignDriver(string driverName);

    }
}
