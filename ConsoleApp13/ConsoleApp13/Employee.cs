using System;

namespace ConsoleApp13
{
    class Employee : Person, IQuittable
    {
        int id;

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
    }
}