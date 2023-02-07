using Library.Management.Models;
using Library.Management.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrgA1CSh.Helpers
{
    internal class StudentHelper
    {
        private StudentService studentService = new StudentService();
        public void CreateStudentRecord(Person? selStudent = null)
        {
            
            Console.WriteLine("What is the name of the student?");
            var name = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("What is the ID of the student");
            var id = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("What is the classification of the student? (Fr, So, Ju, Se) ");
            var classification = Console.ReadLine() ?? string.Empty;
            PersonClassification classEnum = PersonClassification.Freshman;

            if (classification.Equals("Fr", StringComparison.InvariantCultureIgnoreCase))
            {
                classEnum = PersonClassification.Freshman;
            }
            else if (classification.Equals("So", StringComparison.InvariantCultureIgnoreCase))
            {
                classEnum = PersonClassification.Sophomore;
            }
            else if (classification.Equals("Ju", StringComparison.InvariantCultureIgnoreCase))
            {
                classEnum = PersonClassification.Junior;
            }
            else if (classification.Equals("Se", StringComparison.InvariantCultureIgnoreCase))
            {
                classEnum = PersonClassification.Senior;
            }
            else
            {
                classEnum = PersonClassification.Freshman;
            }

            bool isCreate = false;
            if(selStudent == null)
            {
                isCreate = true;
                selStudent = new Person();
            }

            selStudent.Id = int.Parse(id ?? "0");
            selStudent.Name = name ?? string.Empty;
            selStudent.Classification = classEnum;

            if(isCreate)
            {
                studentService.Add(selStudent);
            }
        }

        public void UpdateStudentRecord()
        {
            Console.WriteLine("Select a student to update");
            ListStudents();

            var selstr = Console.ReadLine() ?? string.Empty;

            if(int.TryParse(selstr, out int selInt))
            {
                var selStudent = studentService.Students.FirstOrDefault(s => s.Id == selInt);
                if(selStudent != null)
                {
                    CreateStudentRecord(selStudent);
                }
            
            }
        }
        public void ListStudents ()
        {
            studentService.Students.ForEach(Console.WriteLine);
        }

        public void SearchStudents()
        {
            Console.WriteLine("Enter a Query: ");
            var q = Console.ReadLine() ?? string.Empty;

            studentService.Search(q).ToList().ForEach(Console.WriteLine);
        }
    }
}
