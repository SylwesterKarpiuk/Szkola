using System.Collections.Generic;

namespace Szkola.Class
{
    public class SchoolSubject
    {
        public string Name { get; set; }
        public List<string> Lessons { get; set; }
        public List<string> Tasks { get; set; }
        public SchoolSubject(string name)
        {
            Name = name;
            Lessons = new List<string>();
            Tasks = new List<string>();
        }

        public bool AddLesson(string lesson)
        {
            if (!Lessons.Contains(lesson))
            {
                Lessons.Add(lesson);
                return true;
            }
            else
            {
                return false;
            }
        }
        public int lessonsCount()
        {
            return Lessons.Count;
        }
        public bool AddTask(string task)
        {
            if (!Tasks.Contains(task))
            {
                Tasks.Add(task);
                return true;
            }
            else
            {
                return false;
            }
        }
        public int TaskCount()
        {
            return Tasks.Count;
        }
        public bool TaskRemove(string name)
        {
            if (Tasks.Contains(name))
            {
                Tasks.Remove(name);
                return true;
            }
            else
            {
                return false;
            }
        }
            public bool LessonRemove(string name)
            {
                if (Lessons.Contains(name))
                {
                    Lessons.Remove(name);
                    return true;
                }
                else
                {
                return false;
                }
            }

        }
}