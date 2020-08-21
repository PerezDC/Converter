using System;

namespace Converter
{
    class Program
    {
        public static void ConvertMe(double kilometer)
        {
            double mileage = kilometer / 1.609;
            Console.WriteLine($"{kilometer} km equals {mileage}.");
        }

        double GetMiFromUser()
        {
            Console.WriteLine("Enter mileage: ");
            double Miles = Convert.ToDouble(Console.Read());
            return Miles;
        }

        double GetKiFromUser()
        {
            Console.WriteLine("Enter kilometers: ");
            double Kiloms = Convert.ToDouble(Console.Read());
            return Kiloms;
        }

        static void Main(string[] args)
        {
            double myDistance = 60;
            ConvertMe(myDistance);
            MySpeed.MphToKmph(5);
            MySpeed.KmphToMph(5);
        }
    }
}
