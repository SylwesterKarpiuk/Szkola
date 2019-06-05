using System.Collections.Generic;
using System.Linq;

namespace Szkola.Class
{
    public class Teacher
    {
        public string FullName { get; set; }
        public List<SchoolSubject> SchoolSubjects { get; set; }
        public Teacher(string fullName)
        {
            this.FullName = fullName;
            this.SchoolSubjects = new List<SchoolSubject>();
        }
        public bool AddSchoolSubject(SchoolSubject schoolSubject)
        {
            if (SchoolSubjects.Where(n => n.Name == schoolSubject.Name).FirstOrDefault() == null)
            {
                SchoolSubjects.Add(schoolSubject);
                return true;
            }
            else
            {
                return false;
            }
           
        }
        public bool RemoveSchoolSubject(string name)
        {
            if (SchoolSubjects.Where(n => n.Name == name) != null)
            {
                SchoolSubjects.Remove(SchoolSubjects.Where(n => n.Name == name).FirstOrDefault());
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}