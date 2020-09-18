using CharpterThreeExercises.Exercises;
using System;

namespace CharpterThreeExercises
{
    class MainProgram
    {   
        static string name;
        static int age;
        static void Main(string[] args)
        {
            ParameterizedMethodDemo demo = new ParameterizedMethodDemo();

            ////Method call of value parameter
            //demo.ValueParam("Julius", 23);

            ////Method call for reference parameter
            //demo.RefParam(ref name, ref age );

            ////Method call for output parameter
            //demo.OutputParam(out name, out age);

            ////Factoial Demo
            //Console.WriteLine("\nFactorial Demo");
            //FactorialDemo obj = new FactorialDemo();
            //Console.WriteLine("The factorial of 6 is " + obj.Factorial(6));

            ////Swapping Numbers
            //Console.WriteLine("\nSwapping Numbers Demo Version");
            //SwapNumber classobj = new SwapNumber();
            //int Number1, Number2;
            //Console.WriteLine("Enter first number: ");
            //Number1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter second number: ");
            //Number2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("The vlaue of first number is {0}", Number1);
            //Console.WriteLine("The value of second number is {0}", Number2);
            //classobj.SwapNum(ref Number1, ref Number2);

            //Console.WriteLine("Now the value of first number after swapping is {0}", Number1);
            //Console.WriteLine("Now the value of second number after swapping is {0}", Number2);

            ////Constructor Demo

            ////Instance and Parameterized Constructor Demo
            //Console.WriteLine("Parameterized Constructor Demo");
            //ConstructorDemo ConstDemo1 = new ConstructorDemo(12, 21);
            //ConstDemo1.AddNumber();
            //ConstDemo1.DisplayNumber();
            //ConstructorDemo pConstDemo = new ConstructorDemo();

            ////Life Circle of Ojbects with Constructor and Deconstructor Demo
            //Console.WriteLine("\nApplication of object lifecyle");
            //Console.WriteLine("Main() Begins");
            //ObjectLifeCycle olc = new ObjectLifeCycle();
            //{
            //    Console.WriteLine("Inner Block Begins");
            //    ObjectLifeCycle olc2 = new ObjectLifeCycle();
            //    Console.WriteLine("Inner Block Ends");
            //}
            //Console.WriteLine("Main() Ends");

            ////Counting number of objects in the class
            //Console.WriteLine("\nCounting object in a class");
            //ObjectCount obc1 = new ObjectCount();
            //ObjectCount obc2 = new ObjectCount();
            //ObjectCount obc3 = new ObjectCount();

            //Console.WriteLine("The number of object in this class is {0}.", obc3.Display());

            //Solutions to exercises
            //Arithmetic Operations
            Console.WriteLine("\nSolution to Exercises Begins");
            Console.WriteLine("Performing all arithmetic operations");
            ArithmeticOps AOPs = new ArithmeticOps();
            AOPs.GetValues();
            AOPs.Addition();
            AOPs.Subtraction();
            AOPs.Multiplication();
            AOPs.Division();
            AOPs.Mudular();

            //Greatest of three numbers entered
            Console.WriteLine("\nFinding the greatest of three numbers entered.");
            GreatestNum gn = new GreatestNum();
            gn.GetValues();
            gn.evaluateNums1();
            gn.evaluateNums2();
        }
    }
}
