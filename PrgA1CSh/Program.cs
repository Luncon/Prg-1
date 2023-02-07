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
            var courseHelper = new CourseHelper();
            bool cont = true;

            while (cont)
            {
                Console.WriteLine("Choose an action");
                Console.WriteLine("Add Student to Enrollment (1)");
                Console.WriteLine("List All Enrolled Students (2)");
                Console.WriteLine("Search for a Student (3)");
                Console.WriteLine("Add a New Course (4)");
                Console.WriteLine("Update Student Enrolled (5)");
                Console.WriteLine("List All Courses (6)");
                Console.WriteLine("Exit (0)");
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
                        studentHelper.SearchStudents(); 
                    }
                    else if (value == 4)
                    {
                        courseHelper.CreateCourseRecord();
                    }
                    else if (value == 5)
                    {
                        studentHelper.UpdateStudentRecord();
                    }
                    else if (value == 6)
                    {
                        courseHelper.ListCourses();
                    }
                    else if (value == 0)
                    {
                        cont = false;
                    }
                }
            }
        }
    }
}