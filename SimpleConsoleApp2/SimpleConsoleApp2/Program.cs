using System;

namespace SimpleConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 3;
            int num2 = 2;
            int num3 = 5;
            int num4 = 4;
            bool eval = num1 > num2 & num3 > num4;

            Console.WriteLine(num1.ToString() + " > " + num2.ToString() + " and " + num3.ToString() + " > " + num4.ToString() + " is: " + eval);
            Console.ReadLine();

            //
            bool eval2 = num1 > num2 || num3 > num4;

            Console.WriteLine(num1.ToString() + " > " + num2.ToString() + " or " + num3.ToString() + " > " + num4.ToString() + " is: " + eval2);
            Console.ReadLine();

            //
            bool eval3 = num2 + num2 != num4;

            Console.WriteLine(num2.ToString() + " does not equal " + num2.ToString() + " is: " + eval3);
            Console.ReadLine();
        }
    }
}
