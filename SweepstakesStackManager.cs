using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class SweepstakesStackManager //: ISweepstakesManager
    {
        //member variables (HAS A)
        Stack<Sweepstakes> stack;

        //constructor (SPAWNER)
        public SweepstakesStackManager()
        {
            
        }
        //member methods (CAN DO)
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }
        Sweepstakes GetSweepstakes()
        {
            return stack.Pop();
        }
    }
}
