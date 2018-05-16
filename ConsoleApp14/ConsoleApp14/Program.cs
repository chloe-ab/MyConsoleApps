
using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { Id = 5 };
            Employee employee2 = new Employee() { Id = 6 };
            //List<Employee> employees = new List<Employee>() { };
            //employees.Add(employee);
            //employees.Add(employee2);

            Console.WriteLine(Convert.ToString(employee == employee2));
            Console.ReadLine();
        }

    }
}
