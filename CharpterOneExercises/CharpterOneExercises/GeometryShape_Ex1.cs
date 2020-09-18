using System;
using System.Collections.Generic;
using System.Text;

namespace CharpterOneExercises
{
    class GeometryShape_Ex1
    {
        private Double Area;
        private string shape;
        private string color;

        public void GetInput()
        {
            Console.WriteLine("Enter area of shape: ");
            Area = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter shape: ");
            shape = Console.ReadLine();
            Console.WriteLine("Enter color: ");
            color = Console.ReadLine();
            Console.WriteLine();
        }

        public void Display()
        {
            Console.WriteLine("Your Shape Details\n");
            Console.WriteLine("Area of shape is: " + Area);
            Console.WriteLine("Shape type is: " + shape);
            Console.WriteLine("Color of shape is: " + color);
        }
    }
}
