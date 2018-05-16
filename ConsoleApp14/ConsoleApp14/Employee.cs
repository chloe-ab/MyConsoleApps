using System;

namespace ConsoleApp14
{
    class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Employee name: " + firstName + " " + lastName);
            Console.ReadLine();
        }
        public void Quit()
        {
            Console.WriteLine(firstName + " " + lastName + " is quitting their job.");
            Console.ReadLine();
        }

        public static bool operator ==(Employee employee, Employee employee2) //, bool areEqual)
        {
            if (employee.Id == employee2.Id) //(employees.First().Id == employees.ElementAt(1).Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Employee employee, Employee employee2)
        {
            if (employee.Id == employee2.Id)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
