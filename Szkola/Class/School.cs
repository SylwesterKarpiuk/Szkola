using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Szkola.Class
{
    public class School
    {
        public string Name { get; set; }
        public List<Classroom> Classrooms { get; set; }
        public List<Student> Students { get; set; }
        public School(string name)
        {
            this.Name = name;
            this.Classrooms = new List<Classroom>();
            this.Students = new List<Student>();
        }
        public bool AddStudent(Student student)
        {
            if (Students.Where(n => n.Id == student.Id).FirstOrDefault() == null)
            {
                try
                {
                    student.Id = Students.OrderByDescending(c => c.Id).Take(1).First().Id + 1;
                   
                }
                catch (Exception)
                {
                    student.Id = 1;
                }
                finally
                {
                    Students.Add(student);
                }
                
                return true;
            }
            else
            {
                return false;
            }
           
        }
        public bool RemoveStudent(string firstName)
        {
            try
            {
                if (Students.Where(n => n.FirstName == firstName).FirstOrDefault() != null)
                {
                    Students.Remove(Students.Where(n => n.FirstName == firstName).FirstOrDefault());
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
            
           
        }
        public bool AddClassRoom(Classroom classroom)
        {

            if (Classrooms.Where(n => n.Name == classroom.Name).FirstOrDefault() == null)
            {
                Classrooms.Add(classroom);
                return true;
            }
            else
            {
                return false;
            }
           
        }
        public bool RemoveClassroom(string Name)
        {
            if (Classrooms.Where(n => n.Name == Name).FirstOrDefault() != null)
            {
                Classrooms.Remove(Classrooms.Where(n => n.Name == Name).First());
                return true;
            }
            else
            {
                return false;
            }
           
        }
    }
}
