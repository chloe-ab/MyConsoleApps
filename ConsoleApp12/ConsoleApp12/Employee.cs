using System;

namespace ConsoleApp12
{
    class Employee : Person
    {
        int id;

        public override void SayName()
        {
            Console.WriteLine("Employee name: " + firstName + " " + lastName);
            Console.ReadLine();
        }
    }
}
