using Library.Management.Models;
using PrgA1CSh.Helpers;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentHelper = new StudentHelper();
            Console.WriteLine("Choose an action");
            Console.WriteLine("Add Student to Enrollment (1)");
            Console.WriteLine("Exit (2)");
            var input = Console.ReadLine();

            if (int.TryParse(input, out int value))
            {
                while (value != 2)
                {
                    if (value == 1)
                    {
                        studentHelper.CreateStudentRecord();
                    }

                    input = Console.ReadLine();
                    int.TryParse(input, out value);
                }
            }
        }
    }
}