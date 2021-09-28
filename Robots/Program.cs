using System;
using System.Collections.ObjectModel;

namespace Robots
{
    class Program
    {
        static void Main(string[] args)
        {
            var robots = new Collection<Robot>();
            Robot robot1 = new Robot();
            Robot robot2 = new Robot();
            Robot robot3 = new Robot();

            robot1.Origen = "Raspberry";
            robot2.Origen = "PC";
            robot3.Origen = "Arduino";

            robot1.Ability  = "Habla francés";
            robot2.Ability = "Cuida perros";
            robot3.Ability = "Hace ruido";

            
            robots.Add(robot1 );
            robots.Add(robot2);
            robots.Add(robot3);

            //intocable
            foreach (var robot in robots)
            {
                robot.DoStuff();
            }
            
        }
    }

    class Robot
    {
        private string  _origen;
        private string _ability;

        public string Origen
        {
            get => _origen;
            set => _origen = value;
        }

        public string Ability
        {
            get => _ability;
            set => _ability = value;
        }

        public void DoStuff()
        {
            Console.WriteLine("El origen del robot es {0} y la habilidad es {1}",_origen,_ability);
        }
    }
}
