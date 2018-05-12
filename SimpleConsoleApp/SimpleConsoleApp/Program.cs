using System;

namespace SimpleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string multiplicand = Console.ReadLine();

            int result = Convert.ToInt32(multiplicand) * 50;
            Console.WriteLine("Your number times 50 is: " + result.ToString());
            Console.ReadLine();

            //
            Console.WriteLine("Enter another number");
            string additionBase = Console.ReadLine();

            int additionResult = Convert.ToInt32(additionBase) + 25;
            Console.WriteLine("Your number plus 25 is: " + additionResult.ToString());
            Console.ReadLine();

            //
            Console.WriteLine("Enter another number");
            string dividend = Console.ReadLine();

            double quotient = double.Parse(dividend) / 12.5;
            Console.WriteLine("Your number divided by 12.5 is: " + quotient.ToString());
            Console.ReadLine();

            //
            Console.WriteLine("Enter another number");
            string num = Console.ReadLine();

            bool isGreaterThan = Convert.ToDouble(num) > 50;
            Console.WriteLine("Your number is greater than 50 is: " + isGreaterThan);
            Console.ReadLine();

            //
            Console.WriteLine("Enter another number");
            string dividend2 = Console.ReadLine();

            double remainder = double.Parse(dividend2) % 7;
            Console.WriteLine("The remainder of your number divided by 7 is: " + remainder.ToString());
            Console.ReadLine();

        }
    }
}
