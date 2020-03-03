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
        string firstName = "";
        string lastName = "";
        string emailAddress = "";
        int registrationNumber = 0;

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
            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();
            UserInterface.GetUserInputFor(firstName);
        }
        public void GetLastName()
        {
            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();
            UserInterface.GetUserInputFor(lastName);
        }
        public void GetEmail()
        {
            Console.WriteLine("What is your email address?");
            emailAddress = Console.ReadLine();
            UserInterface.GetUserInputFor(emailAddress);
        }
        public void GenerateNumber()
        {
            registrationNumber++;
        }
    }

}
