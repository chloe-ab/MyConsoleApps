
using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { Id = 5 };
            Employee employee2 = new Employee() { Id = 6 };

            Console.WriteLine(Convert.ToString(employee == employee2));
            Console.ReadLine();
        }

    }
}
