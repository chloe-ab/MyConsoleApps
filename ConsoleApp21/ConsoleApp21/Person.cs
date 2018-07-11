using System;

namespace ConsoleApp21
{
    class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(string firstName, int age) : this(firstName, "", age)
        {
        }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;      
            Age = age;
        }
    }
}

