using System;

namespace ConsoleApp13
{
    class Person
    {
        public string firstName;
        public string lastName;

        public virtual void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
            Console.ReadLine();
        }

    }
}
