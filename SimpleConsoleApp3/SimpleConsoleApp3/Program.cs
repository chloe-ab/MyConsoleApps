using System;

namespace SimpleConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double sixFtInCm = 182.88;
            Console.WriteLine("what is your height in cm?");
            double heightincm = double.Parse(Console.ReadLine());

            if (heightincm > sixFtInCm)
            {
                Console.WriteLine("you're over 6 ft tall!");
            }
            Console.ReadLine();

            //or:

            //double sixFtInCm = 182.88;
            //Console.WriteLine("What is your height in cm?");
            //double heightInCm = double.Parse(Console.ReadLine());

            //if (heightInCm > sixFtInCm)
            //{
            //    Console.WriteLine("You're over 6 ft tall!");
            //}
            //else if (heightInCm < sixFtInCm)
            //{
            //    Console.WriteLine("You're under 6 ft tall!");
            //}
            //else
            //{
            //    Console.WriteLine("Wow, you're exactly 6 ft tall!");
            //}
            //Console.ReadLine();

            ////or:

            //double sixFtInCm = 182.88;
            //Console.WriteLine("What is your height in cm?");
            //double heightInCm = double.Parse(Console.ReadLine());
            //string result = heightInCm > sixFtInCm ? "You're over 6 ft tall!" : "You're not over 6 ft tall!";
            //Console.WriteLine(result);
            //Console.ReadLine();
        }
    }
}
