namespace StudentDataManagement;
class Program
{
    static void Main(string[] args)
    {
        List<Student> students = ReadStudentsFromFile("students.txt");
        // You need to create a students.txt file with sample data

        // Display students
        DisplayStudents(students);

        // Sort students by name
        students = SortStudentsByName(students);
        Console.WriteLine("\nSorted Students:");
        DisplayStudents(students);

        // Search for a student
        Console.Write("\nEnter student name to search: ");
        string searchName = Console.ReadLine();
        Student foundStudent = SearchStudentByName(students, searchName);
        if (foundStudent != null)
        {
            Console.WriteLine($"\nFound Student - Name: {foundStudent.Name}, Class: {foundStudent.Class}");
        }
        else
        {
            Console.WriteLine("\nStudent not found.");
        }
    }

    public static List<Student> ReadStudentsFromFile(string filePath)
    {
        List<Student> students = new List<Student>();

        string[] lines = File.ReadAllLines(filePath);
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            students.Add(new Student { Name = parts[0].Trim(), Class = parts[1].Trim() });
        }

        return students;
    }
    public static void DisplayStudents(List<Student> students)
    {
        foreach (var student in students)
        {
            Console.WriteLine($"Name: {student.Name}, Class: {student.Class}");
        }
    }
    public static List<Student> SortStudentsByName(List<Student> students)
    {
        return students.OrderBy(s => s.Name).ToList();
    }

    public static Student SearchStudentByName(List<Student> students, string name)
    {
        return students.FirstOrDefault(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }
}
