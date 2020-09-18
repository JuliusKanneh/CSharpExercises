using System;
using System.Collections.Generic;
using System.Text;

namespace CharpterThreeExercises
{
    class ParameterizedMethodDemo
    {
        public void ValueParam(string name, int age)
        {
            //Also called input paramerized method
            //Accepts input but doesn't give output
            //Accepts both value or variable during method call.

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Value Parameter Demo");
            Console.WriteLine("Name: " + name + "\nAge: " + age);
        }

        public void RefParam(ref string name, ref int age)
        {
            //Also called input/output parameterized method
            //Accepts input and return value
            //accepts only variable or memory location during method call.

            name = "Julius";
            age = 23;
            Console.WriteLine("\nReference Parameter Demo ");
            Console.WriteLine("Name: " + name + "\nAge: " + age);
        }

        public void OutputParam(out string name, out int age)
        {
            //Give output only

            name = "Julius";
            age = 23;
            Console.WriteLine("\nOutput Parameter Demo");
            Console.WriteLine("Name: " + name + "\nAge: " + age);
        }
    }
}
