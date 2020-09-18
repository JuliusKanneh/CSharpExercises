using System;
using System.Collections.Generic;
using System.Text;

namespace CharpterOneExercises
{
    class Library_Ex6
    {
        private int BookNumber, NumberOfCopies;
        private string BookCategory, AuthorName;

        public void GetBookDetails()
        {
            Console.WriteLine("Enter book number: ");
            BookNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter book category(Fiction / Nonfiction:");
            BookCategory = Console.ReadLine();
            Console.WriteLine("Enter author name: ");
            AuthorName = Console.ReadLine();
            Console.WriteLine("Enter number of copies: ");
            NumberOfCopies = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayBookDetails()
        {
            Console.WriteLine("\nYour Book Details\n");
            Console.WriteLine("Book Number: " + BookNumber);
            Console.WriteLine("Book Category: " + BookCategory);
            Console.WriteLine("Author Name: " + AuthorName);
            Console.WriteLine("Number of copies: " + NumberOfCopies);
        }
    }
}
