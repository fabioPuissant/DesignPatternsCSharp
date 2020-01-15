using System;
using AdapterYT.Adaptee;
using AdapterYT.Adapter;

namespace AdapterYT
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IEnemyAttacker tank = new EnemyTank();
            EnemyRobot enemyRobot = new EnemyRobot();

            IEnemyAttacker adapter = new EnemyRobotAdapter(enemyRobot);

            Console.WriteLine("The base Robot");
            enemyRobot.SmashWithHands();
            enemyRobot.WalkForward();
            enemyRobot.ReactToHuman("Paul");


            Console.WriteLine("");
            Console.WriteLine("The IEnemyAttacker Tank");
            tank.FireWeapon();
            tank.MoveForward();
            tank.AssignDriver("Jeff");

            Console.WriteLine("");
            Console.WriteLine("The IEnemyAttacker EnemyRobotAdapter");
            adapter.FireWeapon();
            adapter.MoveForward();
            adapter.AssignDriver("Mark");
        }
    }
}
