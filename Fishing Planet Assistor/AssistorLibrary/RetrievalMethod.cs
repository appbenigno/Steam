using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_Planet_Assistor
{
    public class RetrievalMethod : RodSettings
    {
        public RetrievalMethod()
        {
            ReelInterval = 1;
            JerkInterval = 1;
            Speed = 1;
            ReelPulse = 1;
            JerkPulse = 1;
        }
        public RetrievalMethod(int reelInterval, int jerkInterval, int speed, int reelPulse, int jerkPulse)
        {
            ReelInterval = reelInterval;
            JerkInterval = jerkInterval;
            Speed = speed;
            ReelPulse = reelPulse;
            JerkPulse = jerkPulse;
        }
    }
}
