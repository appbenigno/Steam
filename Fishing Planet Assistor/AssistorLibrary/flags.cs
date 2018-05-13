using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_Planet_Assistor
{
    public class Flags
    {
        private static List<String> flagger = new List<string>();
    
        public static bool isRaised(String flagString)
        {
            bool result = false;
            if (flagger.Contains(flagString))
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        public static void raise(String flagString)
        {
            if(!isRaised(flagString))
            {
                flagger.Add(flagString);
            }
        }

        public static void destroy(String flagString)
        {
            if(isRaised(flagString))
            {
                flagger.Remove(flagString);
            }
        }

    }
}
