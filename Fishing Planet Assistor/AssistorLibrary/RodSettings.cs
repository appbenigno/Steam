using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_Planet_Assistor
{
    public class RodSettings
    {
        private int reelInterval = 1;
        private int jerkInterval = 1;
        private int speed = 1;
        private int reelPulse = 1;
        private int jerkPulse = 1;
        public int ReelInterval
        {
            get
            {
                return reelInterval;
            }

            set
            {
                reelInterval = value;
            }
        }

        public int JerkInterval
        {
            get
            {
                return jerkInterval;
            }

            set
            {
                jerkInterval = value;
            }
        }

        public int Speed
        {
            get
            {
                return speed;
            }

            set
            {
                speed = value;
            }
        }

        public int ReelPulse
        {
            get
            {
                return reelPulse;
            }

            set
            {
                reelPulse = value;
            }
        }

        public int JerkPulse
        {
            get
            {
                return jerkPulse;
            }

            set
            {
                jerkPulse = value;
            }
        }
    }
}
