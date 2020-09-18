using System;
using System.Collections.Generic;
using System.Text;

namespace CharpterOneExercises
{
    class Conversion
    {
        private Double Distance_km, Distance_m;
        private int Constant = 1000;

        public void GetDistance()
        {
            Console.WriteLine("Enter distance in kilometer: ");
            Distance_km = Convert.ToInt32(Console.ReadLine());
        }

        public void ConvertDistance()
        {
            Distance_m = Distance_km * Constant;
        }

        public void DisplayDistance()
        {
            Console.WriteLine(Distance_km + "kilometer is " + Distance_m + "meter");
        }
    }
}
