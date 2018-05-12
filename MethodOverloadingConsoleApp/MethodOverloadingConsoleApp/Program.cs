using System;

namespace MethodOverloadingConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 4;
            MathOperations mo = new MathOperations(); //I don't think it really makes sense to instantiate this class
            int result = mo.RandomOperation(myInt);
            Console.WriteLine(Convert.ToString(myInt) + " with a random unary math operation applied to it is: " + Convert.ToString(result));
            Console.ReadLine();

            decimal myDec = 4.5m;

            int decResult = mo.RandomOperation(myDec);
            Console.WriteLine(Convert.ToString(myDec) + " with a random unary math operation applied to it is: " + Convert.ToString(decResult));
            Console.ReadLine();

            string myString = "hi";
            bool isValidIntString;
            int stringResult = mo.RandomOperation(myString, out isValidIntString);
            if (isValidIntString)  //need to be able to know if exception was caught or not 
            { 
                Console.WriteLine(Convert.ToString(myString) + " with a random unary math operation applied to it is: " + Convert.ToString(stringResult));
            }
            else
            {
                Console.WriteLine("The string entered was not able to be converted to an integer.");
            }
            Console.ReadLine();

        }
    }
}
