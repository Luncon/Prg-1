﻿using Library.Management.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Management.Models;
namespace PrgA1CSh.Helpers
{
    internal class CourseHelper
    {
        private CourseService courseService = new CourseService();

        public void CreateCourseRecord(Course? selectedCourse = null)
        {
            Console.WriteLine("What is the code of the course?");
            var code = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("What is the name of the course");
            var name = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("What is the description of the course? () ");
            var description = Console.ReadLine() ?? string.Empty;

            bool isNewCourse = false;
            if(selectedCourse == null)
            {
                isNewCourse= true;
                selectedCourse = new Course();
            }


            selectedCourse.Code = code;
            selectedCourse.Name = name;
            selectedCourse.Description = description;
            if(isNewCourse )
            {
                courseService.Add(selectedCourse);
                courseService.Courses.ForEach(Console.WriteLine);
            }
            
        }


        public void UpdateCourseRecord()
        {
            Console.WriteLine("Enter Course Code:");
            ListCourses();

            var selection = Console.ReadLine() ?? string.Empty;

            var selectedCourse = courseService.Courses.FirstOrDefault(s => s.Code.Equals(selection, StringComparison.InvariantCultureIgnoreCase));
            if(selectedCourse!= null)
            {
                CreateCourseRecord(selectedCourse);
            }
        }
        public void ListCourses()
        {
            courseService.Courses.ForEach(Console.WriteLine);
        }

    }
}
