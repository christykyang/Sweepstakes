using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Simulation
    {
        //member variables (HAS A)

        //constructor (SPAWNER)
        public Simulation()
        {
            CreateMarketingFirmWithManager();
        }

        //member methods (CAN DO)
        public void CreateMarketingFirmWithManager()
        {
            ISweepstakesManager sweepstakesManager;
            MarketingFirm marketingFirm;
            UserInterface.PromptUser("What manager type would you like to create (queue or stack)?");
            string managerType = Console.ReadLine();

            switch (managerType)
            {
                case "queue":
                    sweepstakesManager = new SweepstakesQueueManager();
                    marketingFirm = new MarketingFirm(sweepstakesManager);
                    break;
                case "stack":
                    sweepstakesManager = new SweepstakesStackManager();
                    marketingFirm = new MarketingFirm(sweepstakesManager);
                    break;
            }
        }
    }
}
