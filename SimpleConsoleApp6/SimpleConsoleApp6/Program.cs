using System;
using System.Collections.Generic;

namespace SimpleConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] oneDimArray = new string[] {"zero", "one", "two", "three", "four", "five"};
            Console.WriteLine("Select an index of the string array:");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The string at index " + index + " is: " + oneDimArray[index]);
            Console.ReadLine();

            // Parts 2 and 3:
            int[] intArray = new int[] {10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int arrayLength = intArray.Length;
            Console.WriteLine("Select an index of the integer array:");
            int intIndex = Convert.ToInt32(Console.ReadLine());
            
            while (intIndex > arrayLength - 1)
            {
                Console.WriteLine("There is nothing at that index. Please choose a lower index that's equal to or less than " + Convert.ToString(arrayLength - 1) + ":" );
                intIndex = Convert.ToInt32(Console.ReadLine());
            }
           
            Console.WriteLine("The integer at index " + intIndex + " is: " + intArray[intIndex]);
            Console.ReadLine();

            //Part 4:
            List<string> stringList = new List<string> {"blue", "red", "yellow", "green", "purple", "orange", "black", "white"};
            Console.WriteLine("Select an index of the list of strings:");
            int stringIndex = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The string at index " + stringIndex + " is: " + stringList[stringIndex]);
            Console.ReadLine();

        }
    }
}
