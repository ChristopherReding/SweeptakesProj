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
        public static int AssignRegistrationNumber()
        {
            
        }
        public static string GetSweepstakeName()
        {
            Console.WriteLine("Enter name of this sweepstakes");
            return Console.ReadLine();
        }
    }
}
