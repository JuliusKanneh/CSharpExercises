 using System;
using System.Collections.Generic;
using System.Text;

namespace CharpterThreeExercises.Exercises
{
    class GreatestNum
    {
        private int num1, num2, num3;

        public void GetValues()
        {
            Console.WriteLine("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            num3 = Convert.ToInt32(Console.ReadLine());
        }

        public void evaluateNums1()
        {
            if(num1>num2 && num1 > num3)
            {
                Console.WriteLine("The greatest number among {0}, {1} and {2} is {3}", num1, num2, num3, num1);
            }
            else if(num2>num1 && num2 > num3)
            {
                Console.WriteLine("The greatest number among {0}, {1} and {2} is {3}", num1, num2, num3, num2);
            }
            else
            {
                Console.WriteLine("The greatest number among {0}, {1} and {2} is {3}", num1, num2, num3, num3);
            }
        }

        public void evaluateNums2()
        {
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("The greatest number among {0}, {1} and {2} is {3}", num1, num2, num3, num1);
                }
                else
                {
                    Console.WriteLine("The greatest number among {0}, {1} and {2} is {3}", num1, num2, num3, num3);
                }
            }
            else if(num2>num3)
            {
                Console.WriteLine("The greatest number among {0}, {1} and {2} is {3}", num1, num2, num3, num2);
            }
            else
            {
                Console.WriteLine("The greatest number among {0}, {1} and {2} is {3}", num1, num2, num3, num3);
            }

        }
    }
}
