using System;
using System.Collections.Generic;
using System.Text;

namespace CharpterTwoExercises
{
    class MainClass
    {
        static void Main(string[] args)
        {
            ColorChange_Ex1 newColor1 = new ColorChange_Ex1();
            newColor1.AcceptDetails();
            newColor1.addColors();

            InnerClass myClass = new InnerClass();
            myClass.privateMethod();

            FabonnacciSeries_Ex2 mySeries = new FabonnacciSeries_Ex2();
            mySeries.fbSeries();
        }
    }
}
