using System;
using System.Collections.Generic;

namespace OOPSystem
{
  public class DataManager
  {
    public static List<Student> GetStudents()
    {
      // Dummy data
      return new List<Student>
            {
                new Student("Alice", "Class A"),
                new Student("Bob", "Class B"),
                new Student("Charlie", "Class C"),
                // Add more students as needed
            };
    }

    public static List<Teacher> GetTeachers()
    {
      // Dummy data
      return new List<Teacher>
            {
                new Teacher("Mr. Smith", "Class A"),
                new Teacher("Ms. Johnson", "Class B"),
                new Teacher("Mr. Brown", "Class C"),
                // Add more teachers as needed
            };
    }

    public static List<Subject> GetSubjects(List<Teacher> teachers)
    {
      // Dummy data
      return new List<Subject>
            {
                new Subject("Math", "MATH101", teachers[0]),
                new Subject("Science", "SCI101", teachers[1]),
                new Subject("English", "ENG101", teachers[2]),
                // Add more subjects as needed
            };
    }
  }
}
