using System;

namespace Convert
{
    public class Converter
    {
        public static double MphToKmph(double speed) => speed * 1.609;

        public static double KmphToMph(double speed) => speed / 1.609;
    }
}
