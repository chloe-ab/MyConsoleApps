namespace ConsoleApp10
{
    static class MoreMathOperations
    {
        public static int DivideByThreeDeclareRounded(int inputInt, out bool rounded)
        {
            int result = inputInt / 3;
         
            if (inputInt % 3 == 0) //if answer was not rounded
            {
                rounded = false;
            }
            else
            { 
                rounded = true;  //result integer was rounded
            }
            return result;
        }
        
    }
}
