using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class MarketingFirm
    {
        //member variables (HAS A)
        ISweepstakesManager sweepstakesManager;
        
        //constructor (SPAWNER)
        public MarketingFirm(ISweepstakesManager manager)
        {
            sweepstakesManager = manager;
        }
        //member methods (CAN DO)
        public void CreateSweepstake()
        {
            UserInterface.PromptUser("What would you like to call your sweepstake?");
            Sweepstakes newSweepstakes = new Sweepstakes(UserInterface.GetUserInputFor());
            
            

        }
    }
}
