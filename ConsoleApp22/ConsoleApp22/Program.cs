using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool isValid = false;
                int age = 0;
                while (!isValid)
                {
                    Console.WriteLine("What is your age?");
                    isValid = int.TryParse(Console.ReadLine(), out age);
                    if (!isValid)
                    {
                        Console.WriteLine("Please enter a valid integer.");
                    }
                    else if (age == 0)
                    {
                        throw new ZeroAgeException();
                    }
                    else if (age < 0)
                    {
                        throw new NegativeAgeException();
                    }
                }
               
                Console.WriteLine("The year you were born was: " + Convert.ToString(DateTime.Now.Year - age));
                Console.ReadLine();
            }

            catch (ZeroAgeException)
            {
                Console.WriteLine("You must be at least 1 year old.");
                Console.ReadLine();
                return;
            }

            catch (NegativeAgeException)
            {
                Console.WriteLine("Please enter a non-negative integer.");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("An error occured. Please contact your System Administrator.");
                Console.ReadLine();
                return;
            }

        }
    }
}
