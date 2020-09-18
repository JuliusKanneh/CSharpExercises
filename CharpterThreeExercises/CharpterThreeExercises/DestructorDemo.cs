using System;
using System.Collections.Generic;
using System.Text;

namespace CharpterThreeExercises
{
    public class DestructorDemo
    {
        static int Num1, Num2, total;
        public DestructorDemo(int x, int y)
        {
            Num1 = 20;
            Num2 = 30;
            total = 0;
            Console.WriteLine("Constructor invoked");
        }

        ~DestructorDemo()
        {

        }

        public void AddNum()
        {
            total = Num1 + Num2;
            Console.WriteLine("The sum of {0} and {1} is {2} ", Num1, Num2, total);
        }
    }
}
