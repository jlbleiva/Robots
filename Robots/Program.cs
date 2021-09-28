using System;
using System.Collections.ObjectModel;

namespace Robots
{
    class Program
    {
        static void Main(string[] args)
        {
            var robots = new Collection<Robot>();
           
            Robot[] misRobots = new Robot[] { new RobotRaspi(), new RobotPC(), new RobotArduino() };
            foreach (Robot r in misRobots) robots.Add(r);
            
            //intocable
            foreach (var robot in robots)
            {
                robot.DoStuff();
            }
            
        }
    }

    interface IParaDoStuff
    {
        void DoStuff();
    }
    class Robot
    {
        public virtual void DoStuff()
        {
            Console.WriteLine("Es el hacer cosas de la clase superior Robot");
        }

    }

    class RobotRaspi:Robot,IParaDoStuff
    {
        public override void DoStuff()
        {
            Console.WriteLine("el texto de DoStuff para el de RobotRaspi");
        }
    }

    class RobotPC: Robot,IParaDoStuff
    {
        public override void DoStuff()
        {
            Console.WriteLine("el texto de DoStuff para el RobotPC");
        }
    }

    class RobotArduino: Robot,IParaDoStuff 
    {
        public override void DoStuff()
        {
            Console.WriteLine("el texto de DoStuff para el RobotArduino");
        }
    }
}
