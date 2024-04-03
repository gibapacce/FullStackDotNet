using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            string[] arrSubjects = { "English Literature", "English Language", "Maths", "Geography", "History", "Physics", "Chemistry", "Biology" };
            string[] arrSubjectShorts = { "ELIT", "ELANG", "MATH", "GEOG", "HIST", "PHY", "CHEM", "BIO" };

            string[] arrStudents = { "Bruce Lee", "Dave Grohl", "Lady Gaga", "Muhammed Ali", "MC Kevinho", "Kim Kardashian" };
            List<Student> listStudents = new List<Student>();
            List<Subject> listSubjects = new List<Subject>();

            for (int i = 0; i < arrSubjects.Length; i++)
            {
                Subject subject = new Subject();
                subject.Name = arrSubjects[i];
                subject.ShortName = arrSubjectShorts[i];
                listSubjects.Add(subject);
            }

            for (int i = 0; i < arrStudents.Length; i++)
            {
                Student student = new Student();
                student.Name = arrStudents[i];
                student.Address = "Address";
                student.ContactNumber = "12456";
                student.GuardianName = "Guardian Name";
                listStudents.Add(student);
            }

            Teacher classTeacher = new Teacher();
            classTeacher.Name = "Mr.RadheShyam";
            classTeacher.DateOfJoining = Convert.ToDateTime("2010-09-11 00:00:00");
            classTeacher.ContactAddress = "Address";

            CClass class1A = new CClass();
            class1A.Name = "1A";
            class1A.Students = listStudents;
            class1A.Subjects = listSubjects;
            class1A.ClassTeacher = classTeacher;

            // Display student details along with subjects and class information
            foreach (var student in listStudents)
            {
                Console.WriteLine($"Student Name: {student.Name}");
                Console.WriteLine($"Class: {class1A.Name}");
                Console.WriteLine("Subjects:");
                foreach (var subject in listSubjects)
                {
                    Console.WriteLine($" - {subject.Name} ({subject.ShortName})");
                }
                Console.WriteLine();
            }
        }
    }

}
