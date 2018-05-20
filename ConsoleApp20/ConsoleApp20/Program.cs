using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Current date and time is: " + DateTime.Now);
            Console.ReadLine();
            Console.WriteLine("Enter a number: ");
            string hours = Console.ReadLine();
            Double hoursToAdd = Convert.ToDouble(hours);
            DateTime newDateTime = DateTime.Now.AddHours(hoursToAdd);

            Console.WriteLine("The exact time it will be in " + hours + " hours is: " + newDateTime.TimeOfDay);
            Console.ReadLine();
        }
    }
}
