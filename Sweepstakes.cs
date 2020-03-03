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
        }
        //member methods (CAN DO)
        public void RegisterContestant(Contestant contestant)
        {
            numberOfRegisteredContestants++;
            contestants.Add(contestant.registrationNumber, contestant);
        }
        public int PickWinner()
        {
            //need to add KEYvalue
            winner = rnd.Next(numberOfRegisteredContestants);
            return winner;
        }
        public void PrintContestantInfo(Contestant winner)
        {
            Console.WriteLine("The winner of this sweepstakes is " + winner.firstName + winner.lastName);
        }
    }
}
