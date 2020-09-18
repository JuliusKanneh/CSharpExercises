using System;
using System.Collections.Generic;
using System.Text;

namespace CharpterOneExercises
{
    class GameBookingRequestForm_Ex2
    {
        private string name, complexity;
        private int numberOfPlayers;

        public void GetRequest()
        {
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter number of players: ");
            numberOfPlayers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter complexity of game: ");
            complexity = Console.ReadLine();
            Console.WriteLine();
        }

        public void DisplayRequest()
        {
            Console.WriteLine("Your Game Request Details\n");
            Console.WriteLine("Booker Name is: " + name);
            Console.WriteLine("Number of Player is: " + numberOfPlayers);
            Console.WriteLine("Complexity of game booked is: " + complexity);
        }
    }
}
