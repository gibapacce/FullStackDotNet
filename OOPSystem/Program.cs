using System;
using System.Collections.Generic;

namespace OOPSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = DataManager.GetStudents();
            List<Teacher> teachers = DataManager.GetTeachers();
            List<Subject> subjects = DataManager.GetSubjects(teachers);

            DisplayStudentsInClass(students, "Class A");
            DisplaySubjectsTaughtByTeacher(subjects, "Mr. Smith");
        }

        static void DisplayStudentsInClass(List<Student> students, string className)
        {
            Console.WriteLine($"Students in {className}:");
            foreach (var student in students)
            {
                if (student.ClassAndSection == className)
                {
                    Console.WriteLine($"- {student.Name}");
                }
            }
        }

        static void DisplaySubjectsTaughtByTeacher(List<Subject> subjects, string teacherName)
        {
            Console.WriteLine($"Subjects taught by {teacherName}:");
            foreach (var subject in subjects)
            {
                if (subject.Teacher.Name == teacherName)
                {
                    Console.WriteLine($"- {subject.Name}");
                }
            }
        }
    }
}
