﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public interface ISweepstakesManager
    {
        void InseartSweepstakes(Sweepstakes sweepstakes);
        Sweepstakes GetSweepstakes();
            
    }
}
