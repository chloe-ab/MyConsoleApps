using System;
using System.IO;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            string path = "C:\\Users\\Chloe\\source\\repos\\MyConsoleApps\\ConsoleApp19\\Logs\\log.txt";
            File.WriteAllText(path, Console.ReadLine());
            Console.WriteLine(File.ReadAllText(path));
            Console.ReadLine();
        }
    }
}
