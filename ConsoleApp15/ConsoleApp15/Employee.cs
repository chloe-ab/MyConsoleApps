using System;
using System.Collections.Generic;

namespace ConsoleApp15
{
    class Employee<T> : Person, IQuittable 
    {
        public int Id { get; set; }
        public List<T> things; //generic list matching generic type of class

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
