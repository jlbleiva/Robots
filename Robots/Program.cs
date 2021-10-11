using System;
using System.Collections.ObjectModel;
using System.ComponentModel.Design;

namespace Robots
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var pc = new RobotPC(new RobotPCBehavior());
            var arduino = new RobotArduino(new RobotArduinoBehavior());
            var raspi = new RobotRaspi(new RobotRaspiBehavior());

            var robots = new Collection<Robot>(){pc,arduino,raspi};
            
            //intocable
            foreach (var robot in robots)
            {
               
                robot.DoStuff();
            }
            
        }
    }

    
    public interface IRobot
    {
        public void Show();
    }

    public abstract class Robot
    {
        private IRobot _Robotbehavior;
        
        public Robot(IRobot behavior)
        {
            _Robotbehavior = behavior;
        }

        public void DoStuff()
        {
            _Robotbehavior.Show();
        }

        //cambia el comportamiento de cada tipo de robot
        public void ChangeBehavior(IRobot robotBehavior)
        {
            _Robotbehavior = robotBehavior;
        }
    }
    
    public class RobotRaspi: Robot
    {
        public RobotRaspi(IRobot _robotBahavior) : base(_robotBahavior)
        {

        }
        
    }
    public class RobotPC: Robot
    {
        public RobotPC(IRobot _robotBahavior) : base(_robotBahavior)
        {

        }
    }
    public class RobotArduino: Robot 
    {
        public RobotArduino(IRobot _robotBehavior) : base(_robotBehavior)
        {

        }
        
    }

    public class RobotPCBehavior : IRobot
    {
       public void Show()
        {
          Console.WriteLine("Soy PC listo");
        }
    }
    public class RobotArduinoBehavior : IRobot
    {
        
        public void Show()
        {
            Console.WriteLine("Soy Arduino listo");
        }
    }
    public class RobotRaspiBehavior : IRobot
    {

        public void Show()
        {
            Console.WriteLine("Soy Raspi listo");
        }
    }
}
