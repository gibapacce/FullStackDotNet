using System;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            doApp();
        }
        public static void doApp()
        {
            Student[] students = new Student[3];
            for (int i = 0; i < students.Length; i++)
            {
                students[i].name = "Name " + i.ToString();
                students[i].address = "Address of student ";
                students[i].rollNumber = i;
                students[i].className = " VA";
                students[i].dateOfBirth = Convert.ToDateTime("1992-09-10 00:00:00");
            }

            for (int i = 0; i < students.Length; i++)
            {
                Console.Write(students[i].name + ",");
                Console.Write(students[i].address + ",");
                Console.Write(students[i].rollNumber + ",");
                Console.Write(students[i].className + ",");
                Console.Write(students[i].dateOfBirth);
                Console.WriteLine("------------------------");
            }
        }
    }

    struct Student
    {
        public string name;
        public string address;
        public int rollNumber;
        public string className;
        public DateTime dateOfBirth;
    }
}

