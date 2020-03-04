using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        //member variables (HAS A)
        Queue<Sweepstakes> queue;
        //constructor (SPAWNER)
        public SweepstakesQueueManager()
        {
            queue = new Queue<Sweepstakes>();
        }
        //member methods (CAN DO)
        public void InsertSweepstakes (Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            return queue.Dequeue();
        }
    }
}
