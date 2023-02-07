using Library.Management.Models;
using Library.Management.Services;
using PrgA1CSh.Helpers;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentHelper = new StudentHelper();

            bool cont = true;

            while (cont)
            {
                Console.WriteLine("Choose an action");
                Console.WriteLine("Add Student to Enrollment (1)");
                Console.WriteLine("List All Enrolled Students (2)");
                Console.WriteLine("Exit ()");
                var input = Console.ReadLine();
                if (int.TryParse(input, out int value))
                {
  
                    if (value == 1)
                    {
                        studentHelper.CreateStudentRecord();
                    }
                    else if (value == 2)
                    {
                        studentHelper.ListStudents();
                    }
                    else if (value == 3)
                    {
                        cont = false;
                    }
                }
            }
        }
    }
}