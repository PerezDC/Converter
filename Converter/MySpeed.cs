using System;
using System.Collections.Generic;
using System.Text;

namespace Converter
{
    class MySpeed
    {
        public static void MphToKmph(double speed)
        {
            double conversion = speed * 1.609;
            Console.WriteLine($"Speed in KMPH is: {conversion}.");
        }

        public static void KmphToMph(double speed)
        {
            double conversion = speed / 1.609;
            Console.WriteLine($"Speed in MPH is: {conversion}.");
        }
    }
}
