using System;
using System.Collections.ObjectModel;

namespace Robots
{
    class Program
    {
        static void Main(string[] args)
        {
            var robots = new Collection<Robot>();
           
            robots.Add(new RobotRaspi());
            robots.Add(new RobotPC());
            robots.Add(new RobotArduino());

            //intocable
            foreach (var robot in robots)
            {
                robot.DoStuff();
            }
            
        }
    }

    public abstract class Robot
    {
        public abstract void DoStuff();
    }

    public class RobotRaspi:Robot
    {
        public override void DoStuff()
        {
            Console.WriteLine("el texto de DoStuff para el de RobotRaspi");
        }
    }
    public class RobotPC: Robot
    {
        public override void DoStuff()
        {
            Console.WriteLine("el texto de DoStuff para el RobotPC");
        }
    }
    public class RobotArduino: Robot 
    {
        public override void DoStuff()
        {
            Console.WriteLine("el texto de DoStuff para el RobotArduino");
        }
    }
}
