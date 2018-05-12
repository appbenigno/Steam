using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing_Planet_Assistor
{
    public class FishingMode
    {
        public RetrievalMethod Retrieve = new RetrievalMethod(1, 1, 1, 1, 1);
        public RetrievalMethod SlowStraight = new RetrievalMethod(1, 1, 1, 1, 1);
        public RetrievalMethod Straight = new RetrievalMethod(1, 1, 1, 1, 1);
        public RetrievalMethod Twitch = new RetrievalMethod(1, 1, 1, 1, 1);
        public RetrievalMethod StopGo = new RetrievalMethod(1, 1, 1, 1, 1);
        public RetrievalMethod LiftDrop = new RetrievalMethod(1, 1, 1, 1, 1);

        public FishingMode()
        { }

        public void setValue(RetrievalMethod rMethod, NumericUpDown reelInterval, NumericUpDown jerkInterval, NumericUpDown speed, NumericUpDown reelPulse, NumericUpDown jerkPulse)
        {
            rMethod.ReelInterval = Convert.ToInt32(reelInterval.Value);
            rMethod.JerkInterval = Convert.ToInt32(jerkInterval.Value);
            rMethod.Speed = Convert.ToInt32(speed.Value);
            rMethod.ReelPulse = Convert.ToInt32(reelPulse.Value);
            rMethod.JerkPulse = Convert.ToInt32(jerkPulse.Value);
        }
        public void setValue(RetrievalMethod rMethod, int reelInterval, int jerkInterval, int speed, int reelPulse, int jerkPulse)
        {
            rMethod.ReelInterval = Convert.ToInt32(reelInterval);
            rMethod.JerkInterval = Convert.ToInt32(jerkInterval);
            rMethod.Speed = Convert.ToInt32(speed);
            rMethod.ReelPulse = Convert.ToInt32(reelPulse);
            rMethod.JerkPulse = Convert.ToInt32(jerkPulse);
        }
    }
}
