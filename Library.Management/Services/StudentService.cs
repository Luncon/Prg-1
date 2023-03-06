using Library.Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Management.Services
{
    public class StudentService
    {
        private List<Student> studentList;

        private static StudentService? instance;
        private StudentService()
        {
            studentList = new List<Student>();
        }

        public static StudentService Current
        {
            get
            {
                if (instance == null)
                {
                    instance = new StudentService();
                }
                return instance;
            }
        }

        public void Add(Student student)
        {
            studentList.Add(student);
        }

        public List<Student> Students
        {
            get
            {
                return studentList;
            }
        }

        public IEnumerable<Student> Search(string q)
        {
            return studentList.Where(s => s.Name.ToUpper().Contains(q.ToUpper()));
        }
    }
}
