using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Sweepstakes 
    {
        //member variables (HAS A)
        Dictionary<int, Contestant> contestants;
        string name;
        int numberOfRegisteredContestants;
        Random rnd;
        int winner;
        public string Name
        {
            get { return name; }
        }
        //constructor (SPAWNER)
        public Sweepstakes(string sweepstakesName)
        {
            rnd = new Random();
            numberOfRegisteredContestants = 0;
            name = sweepstakesName;
            contestants = new Dictionary<int, Contestant>();
        }
        //member methods (CAN DO)
        public void RegisterContestant(Contestant contestant)
        {
            numberOfRegisteredContestants++;
            contestants.Add(contestant.RegistrationNumber, contestant);
        }
        public int PickWinner()
        {
            //need to add KEYvalue
            winner = rnd.Next(numberOfRegisteredContestants);
            return winner;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Contestant number " + contestant.RegistrationNumber + " is " + contestant.firstName + " " + contestant.lastName + ".");
        }
        public void NotifyContestants(Contestant winner, Contestant contestant)
        {
            for (int i = 0; i < contestants.Count; i++)
            {
                if (contestant.RegistrationNumber == winner.RegistrationNumber)
                {
                    winner.NotifyWinner(winner);
                }
                else
                {
                    contestant.NotifyLoser(contestant);
                }
            }
        }
    }
}
