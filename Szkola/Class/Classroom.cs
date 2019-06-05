using System.Collections.Generic;
using System.Linq;

namespace Szkola.Class
{
    public class Classroom
    {
        public string Name { get; set; }
        public List<Teacher> Teachers { get; set; }
        public Classroom(string name)
        {
            this.Name = name;
            this.Teachers = new List<Teacher>();
        }
        public bool AddTeacher(Teacher teacher)
        {
            if (Teachers.Where(n => n.FullName == teacher.FullName).FirstOrDefault() == null)
            {
                Teachers.Add(teacher);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool RemoveTeacher(string fullName)
        {
            if (Teachers.Where(n => n.FullName == fullName).FirstOrDefault() != null)
            {
                Teachers.Remove(Teachers.Where(n => n.FullName == fullName).First());
                return true;
            }
            else
            {
                return false;
            }
        }
        public int TeachersCount()
        {
            return Teachers.Count;
        }
        public Teacher GetTeacherByFullName(string fullName)
        {
                return Teachers.Where(n => n.FullName == fullName).FirstOrDefault();
        }
    }
}