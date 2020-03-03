using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Contestant
    {
        //member variabless (HAS A)
        public string firstName = "";
        public string lastName = "";
        public string emailAddress = "";
        public int registrationNumber = 0;

        //constructor (SPAWNER)
        public Contestant()
        {
            GetFirstName();
            GetLastName();
            GetEmail();
            GenerateNumber();
        }

        //member methods (CAN DO)
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
