using System;

namespace MethodOverloadingConsoleApp
{
    class MathOperations
    {
        public int RandomOperation(int n) 
        {
            n = n * n;
            return n;
        }

        public int RandomOperation(decimal d)
        {
            d = d * d * d;
            return Convert.ToInt32(d);
        }

        public int RandomOperation(string s, out bool isValidIntString)  //the boolean out parameter will return whether the exception was caught or not
        {                                    
            int n;
            try
            {
                n = Convert.ToInt32(s);
                n = n * n * n * n;
                isValidIntString = true;
            }
            catch (Exception ex)
            {
                isValidIntString = false;
                return 0;
            }
            return n;

        }

    }
}
