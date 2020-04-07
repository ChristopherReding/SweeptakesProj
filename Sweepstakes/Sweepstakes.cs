using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        //member variables
        private Dictionary<int, Contestant> contestants;
        private string name;
        public string Name 
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }

        //constructor
        public Sweepstakes()
        {
            name = UserInterface.GetSweepstakeName();
            contestants = new Dictionary<int, Contestant>();
        }
        public void RegisterContestant()
        {
            Contestant contestant = new Contestant();
            contestant.FirstName = UserInterface.GetUserInputForFirstName();
            contestant.LastName = UserInterface.GetUserInputForLastName();
            contestant.EmailAddress = UserInterface.GetUserInputForEmail();
            contestant.RegistrationNumber = contestants.Count;
            contestants.Add(contestant.RegistrationNumber, contestant);
        }
        public Contestant PickWinner()
        {
            Random random = new Random();
            int winner = random.Next(1, contestants.Count);
            return contestants[winner];
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"{contestant.RegistrationNumber} " +
                $"{contestant.FirstName} {contestant.LastName} {contestant.EmailAddress}");
        }
    }
}
