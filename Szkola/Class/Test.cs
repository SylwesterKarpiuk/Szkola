using System;
using System.Collections.Generic;
using System.Linq;
using Szkola.Class;

namespace Szkola
{
    public class Test
    {
        public School school { get; set; }
        string read;
        int result;
        bool check;
        public void Execute()
        {

            System.Console.WriteLine("Stwórz nową szkołę, aby rozpocząć:");
            System.Console.WriteLine();
            System.Console.WriteLine("Wprowadź nazwę szkoły: ");
            read = System.Console.ReadLine();
            CreateSchool(read);
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Witaj w menu szkoły " + school.Name);
                Console.WriteLine("Wprowadź: ");
                Console.WriteLine("1. aby przejść do menu zarządzania uczniami");
                Console.WriteLine("2. aby przejść do menu zarządzania klasami");
                Console.WriteLine("3. aby zmienić nazwę szkoły");
                Console.WriteLine("4. aby wyjść z programu");
                while (true)
                {
                    read = Console.ReadLine();
                    check = Int32.TryParse(read, out result);
                    if (check == false)
                    {
                        Console.WriteLine("Wprowadzono błędną liczbę, spróbuj jeszcze raz");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                Console.Clear();
                switch (result)
                {
                    case 1:
                        MenuZarzadaniaUczniami(school.Students);
                        break;
                    case 2:
                        MenuZarzadaniaKlasami(school.Classrooms);
                        break;
                    case 3:
                        Console.WriteLine("Wprowadź nową nazwę szkoły");
                        read = Console.ReadLine();
                        school.Name = read;
                        break;
                    case 4:
                        System.Environment.Exit(0);
                        break;
                }

            }


        }
        public void CreateSchool(string name)
        {
            school = new School(name);
        }
        public void MenuZarzadaniaUczniami(List<Student> students)
        {
            Console.Clear();
            bool x = true;
            while (x)
            {
                Console.Clear();
                System.Console.WriteLine("Menu zarządzania uczniami");
                System.Console.WriteLine("Wprowadź: ");
                System.Console.WriteLine("1. aby wyświetlić listę uczniów");
                System.Console.WriteLine("2. aby dodać ucznia");
                System.Console.WriteLine("3. aby wrócić");
                while (true)
                {
                    read = System.Console.ReadLine();
                    check = Int32.TryParse(read, out result);
                    if (check == false)
                    {
                        Console.WriteLine("Wprowadzono błędną liczbę, spróbuj jeszcze raz");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                Console.Clear();
                switch (result)
                {
                    case 1:
                        Console.WriteLine("Uczniowie w szkole: ");
                        int i = 0;
                        foreach (var item in students)
                        {
                            i++;
                            Console.WriteLine(i + ". " + item.FirstName + ", nr: " + item.Id);
                        }
                        Console.WriteLine("Wprowadz: ");
                        Console.WriteLine("1. aby usunąć jednego z uczniów");
                        Console.WriteLine("2. aby wrócić");
                        while (true)
                        {
                            read = System.Console.ReadLine();
                            check = Int32.TryParse(read, out result);
                            if (check == false)
                            {
                                Console.WriteLine("Wprowadzono błędną liczbę, spróbuj jeszcze raz");
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                        Console.Clear();
                        switch (result)
                        {
                            case 1:
                                Console.WriteLine("Wprowadz imię ucznia do usunięcia z systemu");
                                read = Console.ReadLine();
                                if (school.RemoveStudent(read))
                                {
                                    Console.WriteLine("Pomyślnie usunięto ucznia");
                                    Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować");
                                }
                                else
                                {
                                    Console.WriteLine("Uczeń o podanym imieniu nie istnieje w systemie");
                                    Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować");
                                }
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Podaj imie nowego ucznia");
                        read = Console.ReadLine();
                        Student newStudent = new Student(read);
                        school.AddStudent(newStudent);
                        Console.WriteLine("Pomyślnie dodano nowego ucznia");
                        Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować");
                        Console.ReadKey();
                        break;
                    case 3:
                        x = false;
                        break;
                }

            }
        }
        public void MenuZarzadaniaKlasami(List<Classroom> classrooms)
        {
            Console.Clear();
            bool x = true;
            while (x)
            {
                Console.Clear();
                System.Console.WriteLine("Menu zarządzania klasami");
                System.Console.WriteLine("Wprowadź: ");
                System.Console.WriteLine("1. aby wyświetlić listę klas");
                System.Console.WriteLine("2. aby dodać klase");
                System.Console.WriteLine("3. aby wrócić");
                while (true)
                {
                    read = System.Console.ReadLine();
                    check = Int32.TryParse(read, out result);
                    if (check == false)
                    {
                        Console.WriteLine("Wprowadzono błędną liczbę, spróbuj jeszcze raz");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                Console.Clear();
                switch (result)
                {
                    case 1:
                        Console.WriteLine("Klasy w szkole: ");
                        int i = 0;
                        foreach (var item in classrooms)
                        {
                            i++;
                            Console.WriteLine(i + ". " + item.Name);
                        }
                        Console.WriteLine("Wprowadz: ");
                        Console.WriteLine("1. aby usunąć jedną z klas");
                        Console.WriteLine("2. aby przejść do zarządzania klasą");
                        Console.WriteLine("3. aby wrócić");
                        while (true)
                        {
                            read = System.Console.ReadLine();
                            check = Int32.TryParse(read, out result);
                            if (check == false)
                            {
                                Console.WriteLine("Wprowadzono błędną liczbę, spróbuj jeszcze raz");
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                        Console.Clear();
                        switch (result)
                        {
                            case 1:
                                Console.WriteLine("Wprowadz klasy do usunięcia z systemu");
                                read = Console.ReadLine();
                                if (school.RemoveClassroom(read))
                                {
                                    Console.WriteLine("Pomyślnie usunięto klasę");
                                    Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("Klasa o podanej nazwie nie istnieje w systemie");
                                    Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować");
                                    Console.ReadKey();
                                }
                                break;
                            case 2:
                                Console.WriteLine("Wprowadź nazwę klasy: ");
                                read = Console.ReadLine();
                                if (classrooms.Where(n => n.Name == read).FirstOrDefault() != null)
                                {
                                    ClassroomMenu(classrooms.Where(n => n.Name == read).FirstOrDefault());
                                }
                                else
                                {
                                    Console.WriteLine("Klasa o podanej nazwie nie istnieje w systemie");
                                    Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować");
                                    Console.ReadKey();
                                }
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Podaj nazwę nowej klasy");
                        read = Console.ReadLine();
                        Classroom newClassroom = new Classroom(read);
                        if (school.AddClassRoom(newClassroom))
                        {
                            Console.WriteLine("Pomyślnie dodano nową klase");
                            Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Klasa o takiej nazwie już istnieje");
                            Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować");
                            Console.ReadKey();
                        }

                        break;
                    case 3:
                        x = false;
                        break;
                }

            }
        }

        private void ClassroomMenu(Classroom classroom)
        {
            Console.Clear();
            bool x = true;
            while (x)
            {
                Console.Clear();
                Console.WriteLine("Menu zarządzania klasą " + classroom.Name);
                Console.WriteLine("W klasie uczy " + classroom.TeachersCount() + " nauczycieli");
                Console.WriteLine("Wprowadź");
                Console.WriteLine("1. aby wyświetlić listę nauczycieli");
                Console.WriteLine("2. aby dodać nauczyciela");
                Console.WriteLine("3. aby zmienić nazwę klasy");
                Console.WriteLine("4. aby wrócić");
                while (true)
                {
                    read = System.Console.ReadLine();
                    check = Int32.TryParse(read, out result);
                    if (check == false)
                    {
                        Console.WriteLine("Wprowadzono błędną liczbę, spróbuj jeszcze raz");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                Console.Clear();
                switch (result)
                {
                    case 1:
                        Console.WriteLine("Nauczyciele w klasie " + classroom.Name);
                        int i = 0;
                        foreach (var item in classroom.Teachers)
                        {
                            i++;
                            Console.WriteLine();
                            Console.WriteLine(i + ". " + item.FullName);
                        }
                        Console.WriteLine("Wprowadz: ");
                        Console.WriteLine("1. aby usunąć jednego z nauczycieli");
                        Console.WriteLine("2. aby wyświetlić przedmioty jednego z nauczycieli");
                        Console.WriteLine("3. aby wrócić");
                        while (true)
                        {
                            read = System.Console.ReadLine();
                            check = Int32.TryParse(read, out result);
                            if (check == false)
                            {
                                Console.WriteLine("Wprowadzono błędną liczbę, spróbuj jeszcze raz");
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                        Console.Clear();
                        switch (result)
                        {
                            case 1:
                                Console.WriteLine("Wprowadz imię i nazwisko nauczyciela do usunięcia z systemu");
                                read = Console.ReadLine();
                                if (classroom.RemoveTeacher(read))
                                {
                                    Console.WriteLine("Pomyślnie usunięto nauczyciela");
                                    Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("Nauczyciel o podanym imieniu i nazwisku nie istnieje w systemie");
                                    Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować");
                                    Console.ReadKey();
                                }
                                break;
                            case 2:
                                Console.WriteLine("Wprowadz imię i nazwisko nauczyciela");
                                read = Console.ReadLine();
                                if (classroom.Teachers.Where(c => c.FullName == read).FirstOrDefault() != null)
                                {
                                    MenuNauczyciela(classroom.Teachers.Where(c => c.FullName == read).FirstOrDefault());
                                }
                                else
                                {
                                    Console.WriteLine("Nauczyciel o podanym imieniu i nazwisku nie istnieje w systemie");
                                    Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować");
                                    Console.ReadKey();
                                }
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Podaj imie i nazwisko nowego nauczyciela");
                        read = Console.ReadLine();
                        Teacher newTeacher = new Teacher(read);
                        classroom.AddTeacher(newTeacher);
                        Console.WriteLine("Pomyślnie dodano nowego nauczyciela");
                        Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Podaj nową nazwę klasy: ");
                        classroom.Name = Console.ReadLine();
                        Console.WriteLine("Pomyślnie zmieniono nazwę klasy");
                        Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować");
                        Console.ReadKey();
                        break;
                }

            }

        }
        public void MenuNauczyciela(Teacher teacher)
        {
            Console.Clear();
            bool z = true;
            while (z)
            {
                Console.WriteLine("Menu przedmiotów nauczyciela " + teacher.FullName);
                Console.WriteLine("Wprowadź: ");
                Console.WriteLine("1. aby wyświetlić listę przedmiotów");
                Console.WriteLine("2. aby dodać przedmiot");
                Console.WriteLine("3. aby usunąć przedmiot");
                Console.WriteLine("4. aby wrócić");
                while (true)
                {
                    read = System.Console.ReadLine();
                    check = Int32.TryParse(read, out result);
                    if (check == false)
                    {
                        Console.WriteLine("Wprowadzono błędną liczbę, spróbuj jeszcze raz");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                Console.Clear();
                switch (result)
                {
                    case 1:
                        int i = 1;
                        foreach (var item in teacher.SchoolSubjects)
                        {
                            Console.WriteLine(i + ". " + item.Name);
                            Console.WriteLine("Lekcje:");
                            foreach (var item2 in item.Lessons)
                            {
                                Console.WriteLine(item2);
                            }
                            Console.WriteLine("Zadania: ");
                            foreach (var item3 in item.Tasks)
                            {
                                Console.WriteLine(item3);
                            }
                            Console.WriteLine("Wprowadz: ");
                            Console.WriteLine("1. aby dokonać zmian w przedmiocie");
                           
                            Console.WriteLine("2. aby wrócić");
                            while (true)
                            {
                                read = System.Console.ReadLine();
                                check = Int32.TryParse(read, out result);
                                if (check == false)
                                {
                                    Console.WriteLine("Wprowadzono błędną liczbę, spróbuj jeszcze raz");
                                    continue;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            switch (result)
                            {
                                case 1:
                                    Console.WriteLine("Wprowadź nazwę przedmiotu: ");
                                    read = Console.ReadLine();
                                    if (teacher.SchoolSubjects.Where(n => n.Name == read).FirstOrDefault() != null)
                                    {
                                        MenuPrzedmiotu(teacher.SchoolSubjects.Where(n => n.Name == read).FirstOrDefault());
                                    }
                                    break;
                                
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("Wprowadź nazwę nowego przedmiotu:");
                        read = Console.ReadLine();
                        SchoolSubject schoolSubject = new SchoolSubject(read);
                        teacher.AddSchoolSubject(schoolSubject);
                        Console.WriteLine("Pomyślnie dodano przedmiot");
                        Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Wprowadź nazwę przedmiotu do usunięcia:");
                        read = Console.ReadLine();

                        if (teacher.RemoveSchoolSubject(read))
                        {
                            Console.WriteLine("Pomyślnie usunięto przedmiot");
                        }
                        else
                        {
                            Console.WriteLine("Wprowadzono złą nazwę przedmiotu");
                        }

                        Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować");
                        Console.ReadKey();
                        break;
                    case 4:
                        z = false;
                        break;
                }
            }



        }
        public void MenuPrzedmiotu(SchoolSubject schoolSubject)
        {
            Console.Clear();
            Console.WriteLine("Menu przedmiotu " + schoolSubject.Name);
            Console.WriteLine("Wprowadź: ");
            Console.WriteLine("1. aby dodać lekcje");
            Console.WriteLine("2. aby dodać zadanie");
            Console.WriteLine("3. aby wyświetlić liste lekcji");
            Console.WriteLine("4. aby wyświetlić liste zadań");
            Console.WriteLine("5. aby wrócić");
            Console.WriteLine();
            while (true)
            {
                read = System.Console.ReadLine();
                check = Int32.TryParse(read, out result);
                if (check == false)
                {
                    Console.WriteLine("Wprowadzono błędną liczbę, spróbuj jeszcze raz");
                    continue;
                }
                else
                {
                    break;
                }
            }
            int i = 0;
            Console.Clear();
            switch (result)
            {

                case 1:
                    Console.WriteLine("Wprowadz dzień, oraz godzine lekcji");
                    read = Console.ReadLine();
                    if (schoolSubject.AddLesson(read))
                    {
                        Console.WriteLine("Pomyślnie dodano lekcje");
                        Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować");
                        Console.ReadKey();
                    }
                    break;
                case 2:
                    Console.WriteLine("Wprowadz nowe zadanie");
                    read = Console.ReadLine();
                    if (schoolSubject.AddTask(read))
                    {
                        Console.WriteLine("Pomyślnie dodano zadanie");
                        Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować");
                        Console.ReadKey();
                    }
                    break;
                case 3:
                    Console.WriteLine("Lekcje: " + schoolSubject.lessonsCount());
                  

                    foreach (var item in schoolSubject.Lessons)
                    {
                        Console.WriteLine(i + ". " + item);
                    }
                    Console.WriteLine("Wprowadź: ");
                    Console.WriteLine("1. aby usunąć lekcje");
                    Console.WriteLine("2. aby wrócić");
                    while (true)
                    {
                        read = System.Console.ReadLine();
                        check = Int32.TryParse(read, out result);
                        if (check == false)
                        {
                            Console.WriteLine("Wprowadzono błędną liczbę, spróbuj jeszcze raz");
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                    switch (result)
                    {
                        case 1:
                            Console.WriteLine("Wprowadź pełną nazwe lekcji do usunięcia");
                            read = Console.ReadLine();
                            if (schoolSubject.LessonRemove(read))
                            {
                                Console.WriteLine("Pomyślnie usunięto lekcje");
                                Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Wprowadzono błędną nazwę lekcji");
                                Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować");
                                Console.ReadKey();
                            }
                            Console.WriteLine();
                            break;
                    }
                    break;
                case 4:
                    Console.WriteLine("Zadania: " + schoolSubject.TaskCount());
                   
                    foreach (var item in schoolSubject.Tasks)
                    {
                        Console.WriteLine(i + ". " + item);
                    }
                    Console.WriteLine("Wprowadź: ");
                    Console.WriteLine("1. aby usunąć zadanie");
                    Console.WriteLine("2. aby wrócić");
                    while (true)
                    {
                        read = System.Console.ReadLine();
                        check = Int32.TryParse(read, out result);
                        if (check == false)
                        {
                            Console.WriteLine("Wprowadzono błędną liczbę, spróbuj jeszcze raz");
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                    switch (result)
                    {
                        case 1:
                            Console.WriteLine("Wprowadź pełną nazwe zadania do usunięcia");
                            read = Console.ReadLine();
                            if (schoolSubject.TaskRemove(read))
                            {
                                Console.WriteLine("Pomyślnie usunięto zadanie");
                                Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Wprowadzono błędną nazwę zadania");
                                Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować");
                                Console.ReadKey();
                            }
                            Console.WriteLine();
                            break;
                    }
                    break;
            }
        }
    }

}