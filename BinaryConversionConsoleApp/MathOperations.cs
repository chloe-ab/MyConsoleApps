using System;

namespace BinaryConversionConsoleApp   
{
    class MathOperations
    {
        public int ConvertToBinary(int intInDecimal, int leadingZeros = 0) 
        {
            int intInBinary;

            if (intInDecimal == 0)
            {
                intInBinary = 0;
            }
            else
            {
                int exp = 0;
                double binaryBase = 2;
                int p = intInDecimal;

                while (p >= 1)
                {
                    int divisor = Convert.ToInt32(Math.Pow(binaryBase, Convert.ToDouble(exp)));
                    p = intInDecimal / divisor;
                    exp++;
                }
                int arrayLength = exp - 1;
                int[] binaryNum = new int[arrayLength];   //the array represents a binary number; each item in the array represents a digit
                binaryNum[0] = 1;   //highest place value (exluding leading zeros) will contain a 1

                int i = 1;    //starting at the second highest place value in the binary number array

                //r represents remainder
                int r = intInDecimal - Convert.ToInt32(Math.Pow(binaryBase, Convert.ToDouble(exp - 1 - i)));
                while (arrayLength != i) 
                {
                    if (r >= Math.Pow(binaryBase, Convert.ToDouble(exp - 2 - i)))
                    {
                        binaryNum[i] = 1;    
                        r = r - Convert.ToInt32(Math.Pow(binaryBase, Convert.ToDouble(exp - 2 - i))); //r should decrease by an amount equal to that which is represented by the 1 being inserted into the binary number array in the current place value
                    }
                    else
                    {      
                        binaryNum[i] = 0;  //r remains unchanged if no 1's are entered into the binary number array
                    }

                    i++;  //update the current place value
                }

                //turn the array of ints into an array of strings, then concatenate, and convert into an int
                string[] binaryStringArray = new string[arrayLength];
                for (int j = 0; j < arrayLength; j++)
                {
                    binaryStringArray[j] = Convert.ToString(binaryNum[j]);
                }
                string binaryString = String.Join("", binaryStringArray);
                intInBinary = Convert.ToInt32(binaryString);
            }

            return intInBinary;
        }
    }
}
