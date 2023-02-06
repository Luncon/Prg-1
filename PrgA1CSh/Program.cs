using Library.Management.Models;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("hi");

            var myCourse = new Course();
            /*
            List<Person> StudentList = new List<Person>();
            Console.WriteLine("What is the name of the student?");
            var name = Console.ReadLine();
            Console.WriteLine("What is the classification of the student?");
            var classification = Console.ReadLine();
            Console.WriteLine("What is the ID of the student");
            var id = Console.ReadLine();

            var student = new Person
            {
                Id = int.Parse(id ?? "0"),
                Name = name ?? string.Empty,
                Classification = string.IsNullOrEmpty(classification) ? 'F' : classification.ToUpper()[0]
            };
            StudentList.Add(student);
            StudentList.ForEach(Console.WriteLine());  */
        }
    }
}