using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee { Id = 1, firstName = "Joe", lastName = "Blow" };
            Employee employee2 = new Employee { Id = 2, firstName = "Jane", lastName = "Doe" };
            Employee employee3 = new Employee { Id = 3, firstName = "Joe", lastName = "Smith" };
            Employee employee4 = new Employee { Id = 4, firstName = "Adam", lastName = "Smith" };
            Employee employee5 = new Employee { Id = 5, firstName = "Erik", lastName = "D" };
            Employee employee6 = new Employee { Id = 6, firstName = "Chloe", lastName = "Bocker" };
            Employee employee7 = new Employee { Id = 7, firstName = "Michael", lastName = "M" };
            Employee employee8 = new Employee { Id = 8, firstName = "Joe", lastName = "Strong" };
            Employee employee9 = new Employee { Id = 9, firstName = "Danny", lastName = "C" };
            Employee employee10 = new Employee { Id = 10, firstName = "Mila", lastName = "Z" };

            List<Employee> employees = new List<Employee>() { employee1, employee2, employee3, employee4, employee5, employee6, employee7, employee8, employee9, employee10 };

            List<Employee> joes = new List<Employee>();
            foreach (Employee e in employees)
            {
                if (e.firstName == "Joe")
                {
                    joes.Add(e);
                }
            }
            List<Employee> joesWithLambda = new List<Employee>();
            joesWithLambda = employees.Where(x => x.firstName == "Joe").ToList();
            Console.WriteLine(joesWithLambda.Count);
            Console.ReadLine();

            List<Employee> employeesGreaterThanFive = new List<Employee>();
            employeesGreaterThanFive = employees.Where(x => x.Id > 5).ToList();
            Console.WriteLine(employeesGreaterThanFive.Count);
            Console.ReadLine();
        }
    }
}
