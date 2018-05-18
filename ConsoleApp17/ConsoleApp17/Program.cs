using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num = new Number();
            num.Amount = 2.3m;
            Console.WriteLine(num.Amount);
            Console.ReadLine();
        }
    }

    public struct Number
    {
        public decimal Amount { get; set; }
    }
}
