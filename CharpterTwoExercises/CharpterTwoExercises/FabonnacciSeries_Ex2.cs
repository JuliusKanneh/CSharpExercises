using System;
using System.Collections.Generic;
using System.Text;

namespace CharpterTwoExercises
{
    class FabonnacciSeries_Ex2
    {
        public void fbSeries()
        {
            int Num1;
            int Num2;
            int maxVal;
            Num1 = Num2 = 1;

            Console.WriteLine("Print FB series up to what value? ");
            maxVal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Num1);
            while (Num2 < maxVal)
            {
                Console.WriteLine(Num2);
                Num2 += Num1;
                Num1 = Num2 - Num1;
            }
        }
    }
    
}
