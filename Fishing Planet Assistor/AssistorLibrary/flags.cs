using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_Planet_Assistor
{
    public class Flags
    {
        private bool flag;
        public Flags()
        {
            flag = false;
        }
        public Flags(bool state)
        {
            flag = state;
        }
        public bool Flag
        {
           get { return flag; }
            set { flag = value; }
        }
        
        public bool isFlagged()
        {
            return flag;
        }
        /*
        private static bool AutoCatching = false;
        private static bool Straighting = false;
        private static bool SlowStraighting = false;
        private static bool Twitching = false;
        private static bool StopGoing = false;
        private static bool LiftDropping = false;
        private static bool Unsnagging = false;
        private static bool Teasing = false;
        public static bool AutoCatch
        {
            get { return AutoCatching; }
            set { AutoCatching = value; }
        }
        public static bool Straight
        {
            get { return Straighting; }
            set { Straighting = value; }
        }
        public static bool SlowStraight
        {
            get { return SlowStraighting; }
            set { SlowStraighting = value; }
        }
        public static bool Twitch
        {
            get { return Twitching; }
            set { Twitching = value; }
        }
        public static bool StopGo
        {
            get { return StopGoing; }
            set { StopGoing = value; }
        }
        public static bool LiftDrop
        {
            get { return LiftDropping; }
            set { LiftDropping = value; }
        }
        public static bool Unsnag
        {
            get { return Unsnagging; }
            set { Unsnagging = value; }
        }
        public static bool Tease
        {
            get { return Teasing; }
            set { Teasing = value; }
        }

        

        public static void clear()
        {
            Unsnag = false;
            AutoCatch = false;
            LiftDrop = false;
            SlowStraight = false;
            StopGo = false;
            Straight = false;
            Twitch = false;
            Tease = false;
        }*/
    }
}
