using System;
using System.Collections.Generic;
using System.Text;

namespace CharpterThreeExercises
{
    public class SwapNumber
    {
        public void SwapNum(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
}
