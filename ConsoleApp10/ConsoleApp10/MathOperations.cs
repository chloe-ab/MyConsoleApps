namespace ConsoleApp10
{
    class MathOperations
    {
        //void method that outputs an integer:
        public void DivideByTwo(int inputInt, out int result)
        {
            result = inputInt / 2; 
        }

        //overload:
        public void DivideByTwo(double inputNum, out double result)
        {
            result = inputNum / 2;
        }

    }
}
