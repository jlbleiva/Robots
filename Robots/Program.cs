using System;
using System.Collections.ObjectModel;
using System.ComponentModel.Design;

namespace Robots
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var pc = new RobotPC(new SpeakDeutsh(),new Run());
            var arduino = new RobotArduino(new SpeakEnglish(),new Dance());
            var raspi = new RobotRaspi(new SpeakSpanish(), new Dance());

            var robots = new Collection<Robot>(){pc,arduino,raspi};
            
            //intocable
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

    public interface IOtherSkill
    {
        public void  ExecuteSkill();
    }

    public abstract class Robot
    {

        private string firstLanguage;
        private string secondLanguage;

        private ISpeakLanguage _speakLanguage1;
        private IOtherSkill _skill;

       

        public Robot(ISpeakLanguage behavior1, IOtherSkill skill)
        {
            _speakLanguage1 = behavior1;
            _skill = skill;

        }

        public void DoStuff()
        {
            Console.WriteLine("Primer idioma: {0}", _speakLanguage1.ShowLanguage());
           _skill.ExecuteSkill();
            Console.WriteLine("=====================================");
        }

        //cambia el comportamiento de cada tipo de robot
        public void ChangeLanguage1(ISpeakLanguage language)
        {
            _speakLanguage1 = language;
        }

      

    }
    
    public class RobotRaspi: Robot
    {
        public RobotRaspi(ISpeakLanguage _speakLanguage1, IOtherSkill _skill) : base(_speakLanguage1, _skill)
        {

        }
        
    }
    public class RobotPC: Robot
    {
        public RobotPC(ISpeakLanguage _speakLanguage1, IOtherSkill _skill) : base(_speakLanguage1, _skill)
        {

        }
    }
    public class RobotArduino: Robot 
    {
        public RobotArduino(ISpeakLanguage _speakLanguage1, IOtherSkill _skill) : base(_speakLanguage1, _skill)
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

    public class Dance : IOtherSkill
    {
        public void  ExecuteSkill()
        {
            Console.WriteLine("I like dancing");
        }
    }

    public class Run : IOtherSkill
    {
        public void  ExecuteSkill()
        {
            Console.WriteLine("I like running");
        }
    }
}
