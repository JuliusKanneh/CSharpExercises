using System;
using System.Collections.Generic;
using System.Text;

namespace CharpterThreeExercises
{
    class FactorialDemo
    {
        //Applicable example of recursion of methods in c#.
        public int Factorial(int n)
        {
            int result;

            if(n == 1)
            {
                return 1;
            }
            else
            {
                result = Factorial(n - 1) * n;
                return result;
            }

        }
    }
}
