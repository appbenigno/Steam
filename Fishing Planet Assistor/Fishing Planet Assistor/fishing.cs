using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowHook;
using System.Windows.Forms;
using System.Threading;

namespace Fishing_Planet_Assistor
{
    class fishing : globals
    {
        private static int lastReelSpeed;
        public static int jerkTickTemp = 0;
        public static int jerkTick = 0;
        public static int reelTick = 0;
        public static void focusParent()
        {
            WinHook.SetForegroundWindow(parentHandle);
        }
        public static void focusProgram()
        {
            WinHook.SetForegroundWindow(programHandle);
        }
        public static void lineJerk(int count)
        {
            for (int x = count; x > 0; x--)
            {
                SendKeys.Send(Convert.ToChar(Keys.Enter).ToString());
            }
        }
        public static void lineReel(int count)
        {
            for (int x = count; x > 0; x--)
            {
                SendKeys.Send(Convert.ToChar(Keys.Space).ToString());
            }
        }
        public static void setReelingSpeed(int speed)
        {
            int counter = 0;
            if (speed < lastReelSpeed)
            {
                counter = lastReelSpeed - speed;
                for (; counter > 0; counter--)
                {
                    SendKeys.SendWait(Convert.ToChar(Keys.K).ToString());
                    Thread.Sleep(300);
                }
            }
            else if (speed > lastReelSpeed)
            {
                counter = speed - lastReelSpeed;
                for (; counter > 0; counter--)
                {
                    SendKeys.SendWait(Convert.ToChar(Keys.L).ToString());
                    Thread.Sleep(300);
                }
            }
            lastReelSpeed = speed;
        }
        public static void resetReelingSpeed()
        {
            lastReelSpeed = 0;
            for (int x = 5; x > 0; x--)
            {
                SendKeys.SendWait(Convert.ToChar(Keys.K).ToString());
                Thread.Sleep(300);
            }
            setReelingSpeed(1);
        }
    }
}
