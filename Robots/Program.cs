using System;
using System.Collections.ObjectModel;
using System.ComponentModel.Design;

namespace Robots
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var pc = new RobotPC(new SpeakDeutsh(),new SpeakEnglish());
            var arduino = new RobotArduino(new SpeakEnglish(),new SpeakSpanish());
            var raspi = new RobotRaspi(new SpeakSpanish(), new SpeakRussian());

            var robots = new Collection<Robot>(){pc,arduino,raspi};
            
            //intocable
            foreach (var robot in robots)
            {
               
                robot.DoStuff();
            }
           
            pc.ChangeLanguage2(new SpeakSpanish());

            Console.WriteLine("=====================================");
            Console.WriteLine("Tras los cambios");
            foreach (var robot in robots)
            {

                robot.DoStuff();
            }
            
          
        }
    }

    
    public interface ISpeakLanguage
    {
        public string  ShowLanguage();
    }

    public abstract class Robot
    {

        private string firstLanguage;
        private string secondLanguage;

        private ISpeakLanguage _speakLanguage1;
        private ISpeakLanguage _speakLanguage2;

       

        public Robot(ISpeakLanguage behavior1, ISpeakLanguage behavior2)
        {
            _speakLanguage1 = behavior1;
            _speakLanguage2 = behavior2;

        }

        public void DoStuff()
        {
            Console.WriteLine("Primer idioma: {0}", _speakLanguage1.ShowLanguage());
            Console.WriteLine("Segundo idioma: {0}", _speakLanguage2.ShowLanguage());
            Console.WriteLine("=====================================");
        }

        //cambia el comportamiento de cada tipo de robot
        public void ChangeLanguage1(ISpeakLanguage language)
        {
            _speakLanguage1 = language;
        }

        public void ChangeLanguage2(ISpeakLanguage language)
        {
            _speakLanguage2 = language;
        }

    }
    
    public class RobotRaspi: Robot
    {
        public RobotRaspi(ISpeakLanguage _speakLanguage1, ISpeakLanguage _speakLanguage2) : base(_speakLanguage1, _speakLanguage2)
        {

        }
        
    }
    public class RobotPC: Robot
    {
        public RobotPC(ISpeakLanguage _speakLanguage1, ISpeakLanguage _speakLanguage2) : base(_speakLanguage1, _speakLanguage2)
        {

        }
    }
    public class RobotArduino: Robot 
    {
        public RobotArduino(ISpeakLanguage _speakLanguage1, ISpeakLanguage _speakLanguage2) : base(_speakLanguage1, _speakLanguage2)
        {

        }
        
    }

    public class SpeakEnglish : ISpeakLanguage
    {
     

        public string ShowLanguage()
        {
           return ("I speak english");
        }
    }

    public class SpeakSpanish : ISpeakLanguage
    {
        public string  ShowLanguage()
        {
            return ("I speak spanish");
        }
    }

    public class SpeakDeutsh : ISpeakLanguage
    {
        public string  ShowLanguage()
        {
            return ("I speak deutsh");
        }
    }

    public class SpeakRussian : ISpeakLanguage
    {
        public string  ShowLanguage()
        {
            return ("I speak russian");
        }
    }
}
