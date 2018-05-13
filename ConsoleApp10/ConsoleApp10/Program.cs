using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations mo = new MathOperations();
            Console.WriteLine("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            mo.DivideByTwo(input, out int result);
            Console.WriteLine("Your number divided by 2 is: " + Convert.ToString(result));
            Console.ReadLine();

            Console.WriteLine("Enter another number: ");
            double inputDouble = Convert.ToDouble(Console.ReadLine());
            mo.DivideByTwo(inputDouble, out double resultDouble);
            Console.WriteLine("Your number divided by 2 is: " + Convert.ToString(resultDouble));
            Console.ReadLine();

            Console.WriteLine("Enter another number: ");
            int input3 = Convert.ToInt32(Console.ReadLine());
            int result3 = MoreMathOperations.DivideByThreeDeclareRounded(input3, out bool rounded);
            string roundedString = ", exactly.";
            if (rounded)
            {
                roundedString = ", and was rounded down to the nearest integer.";
            }
            Console.WriteLine("Your number divided by 3 is: " + Convert.ToString(result3) + roundedString);
            Console.ReadLine();
        
        }
    }
}
