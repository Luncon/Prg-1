namespace Library.Management
{
    public class Person
    {
        public string Name { get; set; }
        public string Dictionary<int, double> Grades { get; set; }
        public char Classification { get; set; }
        public Person()
        {
            Name = string.Empty;
            Grades = new Dictionary<int, double>();
        }
    }
}  