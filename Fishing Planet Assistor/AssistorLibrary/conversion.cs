using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_Planet_Assistor
{
    public class conversion
    {
        /// <summary>
        /// Distance Conversion
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static double cm_to_m(double length)
        {
            double result;
            result = length / 100;
            return Math.Round(result, 2);
        }
        
        public static double m_to_cm(double length)
        {
            double result;
            result = length * 100;
            return Math.Round(result, 2);
        }

        public static double in_to_cm(double length)
        {
            double result;
            result = length * 2.54;
            return Math.Round(result, 2);
        }

        public static double cm_to_in(double length)
        {
            double result;
            result = length / 2.54;
            return Math.Round(result, 2);
        }

        public static double in_to_ft(double length)
        {
            double result;
            result = length / 12;
            return Math.Round(result, 2);
        }
        public static double ft_to_in(double length)
        {
            double result;
            result = length * 12;
            return Math.Round(result, 2);
        }

        /// <summary>
        /// Mass Conversion
        /// </summary>
        /// <param name="mass"></param>
        /// <returns></returns>
        public static double g_to_kg(double mass)
        {
            double result;
            result = mass / 1000;
            return Math.Round(result, 2);
        }

        public static double kg_to_g(double mass)
        {
            double result;
            result = mass * 1000;
            return Math.Round(result, 2);
        }

        public static double oz_to_lbs(double mass)
        {
            double result;
            result = mass * 0.0625;
            return Math.Round(result, 2);
        }

        public static double lbs_to_oz(double mass)
        {
            double result;
            result = mass / 0.0625;
            return Math.Round(result, 2);
        }

        public static double g_to_oz(double mass)
        {
            double result;
            result = mass * 0.035274;
            return Math.Round(result, 2);
        }

        public static double oz_to_g(double mass)
        {
            double result;
            result = mass / 0.035274;
            return Math.Round(result, 2);
        }

    }
}
