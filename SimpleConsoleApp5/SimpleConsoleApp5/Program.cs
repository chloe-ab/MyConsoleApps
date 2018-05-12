using System;
using System.Text;


namespace SimpleConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Chloe ";
            string middleName = "April ";
            string lastName = "Bocker";
            string fullName = firstName + middleName + lastName;

            Console.WriteLine(fullName);
            Console.ReadLine();

            //

            lastName = lastName.ToUpper();

            //

            StringBuilder paragraph = new StringBuilder();
            paragraph.Append("Hi, my name is " + fullName + ".");
            paragraph.Append("\nToday it is Monday.");
            paragraph.Append("\nTomorrow it will be Tuesday.");

            Console.WriteLine(paragraph);
            Console.ReadLine();


        }
    }
}
