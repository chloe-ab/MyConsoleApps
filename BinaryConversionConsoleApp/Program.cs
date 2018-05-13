using System;

namespace BinaryConversionConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations mo = new MathOperations();
            Console.WriteLine("Enter two numbers one at a time: the first being the number that you want converted to binary, and the second (optional) being the number of leading zeros:");

            try
            {
                int firstNum = Convert.ToInt32(Console.ReadLine());
                int result;

                string potentialSecondNumString = Console.ReadLine();
                if (potentialSecondNumString != "")   //if the user enters a second number
                {           
                    int secondNum = Convert.ToInt32(potentialSecondNumString);
                    result = mo.ConvertToBinary(firstNum, secondNum);

                    //create a separate string of leading zeros to concatenate in front of the binary number
                    string leadingZerosString = "";
                    for (int c = 0; c < secondNum; c++)
                    {
                        leadingZerosString = "0" + leadingZerosString;
                    }
                    Console.WriteLine("Your number in binary is: " + leadingZerosString + Convert.ToString(result));

                }
                else  //if the user doesn't enter a second number
                {
                    result = mo.ConvertToBinary(firstNum);
                    Console.WriteLine("Your number in binary is: " + Convert.ToString(result));
                }

                Console.ReadLine();
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("You did not enter a valid integer.");
                Console.ReadLine();
            }
            catch (System.OverflowException ex)
            {
                Console.WriteLine("The integer you entered was too large.");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }

        }
    }
}
