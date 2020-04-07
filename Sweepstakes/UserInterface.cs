using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public  static  class UserInterface
    {
        public static string GetUserInputForFirstName()
        {
            Console.WriteLine("Enter first name");
            return Console.ReadLine();
        }
        public static string GetUserInputForLastName()
        {
            Console.WriteLine("Enter last name");
            return Console.ReadLine();
        }
        public static string GetUserInputForEmail()
        {
            Console.WriteLine("Enter email adress");
            return Console.ReadLine();
        }
        
        public static string GetSweepstakeName()
        {
            Console.WriteLine("Enter name of this sweepstakes");
            return Console.ReadLine();
        }
        public static ISweepstakesManager GetManagerType()
        {
            Console.WriteLine("Which flavor of sweepstakes manager would you like?\n" +
                "Stack or Queue?");
            ISweepstakesManager managerType = null;
            string tempManager = Console.ReadLine();
            switch (tempManager)
            {
                case "Stack":
                    managerType = new SweepstakesStackManager();
                    break;
                case "stack":
                    managerType = new SweepstakesStackManager();
                    break;
                case "Queue":
                    managerType = new SweepstakesQueueManager();
                    break;
                case "queue":
                    managerType = new SweepstakesQueueManager();
                    break;
                default:
                    Console.WriteLine("Not a valid manager type");
                    GetManagerType();
                    break;
            }
            return managerType;
        }
    }
}
