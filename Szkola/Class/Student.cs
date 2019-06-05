namespace Szkola.Class
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public Student(string firstName)
        {
            FirstName = firstName;
            Id = 0;
        }
    }
}