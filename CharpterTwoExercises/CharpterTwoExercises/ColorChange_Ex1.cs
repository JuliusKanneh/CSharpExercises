using System;

namespace CharpterTwoExercises
{
    class ColorChange_Ex1
    {
        private string c1, c2;

        public void AcceptDetails()
        {
            Console.WriteLine("Instructions:");
            Console.WriteLine("1. Please enter the two primary colors you want to add." + "\n RED \n GREEN \n BLUE");
            Console.WriteLine("Please enter the colors in upper case only.");
            Console.WriteLine("Please enter the first colors: ");
            c1 = Console.ReadLine();
            Console.WriteLine("Please enter the second colors:");
            c2 = Console.ReadLine();
        }

        public void addColors()
        {
            if(c1 == "RED" && c2 == "GREEN" || c1 == "GREEN" && c2 == "RED")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Yellow");
            }
            else if (c1 == "RED" && c2 == "BLUE" || c1 == "BLUE" && c2 == "RED")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Magenta");
            }
            else if(c1 == "BLUE" && c2 == "GREEN" || c1 == "GREEN" && c2 == "BLUE")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Cyan");
            }
            else
            {
                Console.WriteLine("Colors you entered are not the correct RGB color combination");
            }
        }
    }

    class InnerClass
    {
        internal void privateMethod()
        {
            Console.WriteLine("Testing Inner class with private specifier.");
        }
    }
}
 