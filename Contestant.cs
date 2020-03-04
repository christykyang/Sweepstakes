using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Contestant : IContestant
    {
        //member variabless (HAS A)
        public string firstName;
        public string lastName;
        public string emailAddress;
        private int registrationNumber;
        public int RegistrationNumber
        {
            get { return registrationNumber; }
        }

        //constructor (SPAWNER)
        public Contestant()
        {
            firstName = "";
            lastName = "";
            emailAddress = "";
            registrationNumber = 0;
        }

        //member methods (CAN DO)
        public void NotifyWinner(IContestant winner)
        {
            Console.WriteLine("Congratulations, you win! Please respond to claim your prize.");
        }
        public void NotifyLoser(IContestant contestant)
        {
            Console.WriteLine("Sorry, you did not win the sweepstakes. If you would like, please enter our new sweepstakes.");
        }
        public void GetFirstName()
        {
            UserInterface.PromptUser("What is your first name?");
            firstName = UserInterface.GetUserInputFor();
        }
        public void GetLastName()
        {
            UserInterface.PromptUser("What is your last name?");
            lastName = UserInterface.GetUserInputFor();
        }
        public void GetEmail()
        {
            UserInterface.PromptUser("What is your email address?");
            emailAddress = UserInterface.GetUserInputFor();
        }
        public void GenerateNumber()
        {
            registrationNumber++;
        }
    }

}
