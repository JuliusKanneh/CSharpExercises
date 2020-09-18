using System;
using System.Collections.Generic;
using System.Text;

namespace CharpterThreeExercises
{
    class ConstructorDemo
    {
        int num1, num2, total;
        static int x;

        //Instance Constructor Demo
        public ConstructorDemo()
        {
            num1 = 20;
            num2 = 12;
        }

        //Static Constructor Demo
        static ConstructorDemo()
        {
            x = 23;
        }

        //Parameterized Constructor Demo
        public ConstructorDemo(int Number1, int Number2)
        {
            num1 = Number1;
            num2 = Number2;
        }

        public void AddNumber()
        {
            total = num1 + num2;
        }

        public void DisplayNumber()
        {
            Console.WriteLine("The total is {0} ", total);
        }
    }
}
