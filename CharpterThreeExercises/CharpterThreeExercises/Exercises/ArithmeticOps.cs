using System;
using System.Collections.Generic;
using System.Text;

namespace CharpterThreeExercises.Exercises
{
    class ArithmeticOps
    {
        static int num1, num2;

        public void GetValues()
        {
            Console.WriteLine("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
        }

        public void Addition()
        {
            Console.WriteLine("The sum of {0} and {1} is {2}.", num1, num2, num1 + num2);
        }

        public void Subtraction()
        {
            Console.WriteLine("\nThe difference between {0} and {1} is {2}.", num1, num2, num1 - num2);
        }

        public void Multiplication()
        {
            Console.WriteLine("\nThe product of {0} and {1} is {2}", num1, num2, num1 * num2);
        }

        public void Division()
        {
            if (num2 != 0)
            {
                Console.WriteLine("\nThe quotient between {0} and {1} is {2}", num1, num2, num1 / num2);
            }
            else
            {
                Console.WriteLine("\n{0} is not divisible by {1}.", num1, num2);
            }
        }

        public void Mudular()
        {
            if(num1 != 0 || num2 != 0)
            {
                Console.WriteLine("\n{0} module {1} is {2}", num1, num2, num1 % num2);
            }
            else
            {
                Console.WriteLine("\nEither or both numbers entered are 0");
            }
        }
    }
}
