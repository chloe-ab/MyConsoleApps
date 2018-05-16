using System;
using System.Collections.Generic;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>() { things = new List<string>() { "first string", "second string" } };

            Employee<int> employee2 = new Employee<int>() { things = new List<int>() { 1, 2, 3} };

            //employee.things.Add("first string");
            //employee.things.Add("second string");

            //employee2.things.Add(1);
            //employee2.things.Add(2);
            //employee2.things.Add(3);

            Console.WriteLine(employee.things[0] + " " + employee.things[1]);
            Console.WriteLine(Convert.ToString(employee2.things[0]) + " " +  Convert.ToString(employee2.things[1]) + " " + Convert.ToString(employee2.things[2]));
            Console.ReadLine();
        }
    }
}
