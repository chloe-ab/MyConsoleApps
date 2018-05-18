using System;

namespace ConsoleApp16
{
    class Program
    {
        public DayOfWeek DayOfWeek { get; set; }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the current day of the week: ");
                string day = Console.ReadLine();
                DayOfWeek parsedDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), day);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }         
        }
    }

    public enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
