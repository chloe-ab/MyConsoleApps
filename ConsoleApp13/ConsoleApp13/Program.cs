
namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable iquit = new Employee() { firstName = "Sample", lastName = "Employee" };
            iquit.Quit();
        }
    }
}


