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
        public List<Person> StudentList = new List<Person>();
        public void Add(Person student)
        {
            StudentList.Add(student);
        }

        public List<Person> Students
        {
            get
            {
                return StudentList;
            }
        }
    }
}
