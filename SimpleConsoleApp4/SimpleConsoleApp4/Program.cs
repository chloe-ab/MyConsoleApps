using System;

namespace SimpleConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a colour.");
            string colour = Console.ReadLine();
            bool isGuessed = colour == "green" || colour == "Green";

            while (!isGuessed)
            {
                Console.WriteLine("Guess again.");
                colour = Console.ReadLine();
                isGuessed = colour == "green" || colour == "Green";
            }
           
            Console.WriteLine("You got it!");
            Console.ReadLine();

            //

            bool secondColourIsGuessed;
            do
            {
                Console.WriteLine("Guess another colour.");

                string secondColour = Console.ReadLine();
                secondColourIsGuessed = secondColour == "blue" || secondColour == "Blue";

            }
            while (!secondColourIsGuessed);

            Console.WriteLine("You got it!");
            Console.ReadLine();

        }
    }
}
