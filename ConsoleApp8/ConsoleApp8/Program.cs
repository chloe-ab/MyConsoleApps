using System;
using System.Collections.Generic;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                List<int> intList = new List<int> { 10, 20, 30, 40, 50 };
                Console.WriteLine("Enter a number that you would like to divide each number in the list by:");  //note that this is rounded int division

                int divisor = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < intList.Count; i++)
                {
                    int quotient = intList[i] / divisor;
                    Console.WriteLine(quotient);
                }
            }
            catch (DivideByZeroException ex)   //div by zero
            {
                Console.WriteLine("You cannot divide by zero; next time please choose a non-zero integer.");
            }
            catch (FormatException ex)  //string
            {
                Console.WriteLine("You cannot divide by a string; next time please choose a non-zero integer.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); //for any unprecedented exceptions
            }
            finally
            {
                Console.WriteLine("Any exceptions have been found; the program is continuing execution.");
                Console.ReadLine();
            }

            Console.ReadLine();

       }
    }
}
