class Program
{
    static void Main(string[] args)
    {
        // Manual entry of students
        List<Student> students = new List<Student>();
        Console.WriteLine("Enter details for 4 students:");
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"Enter details for student {i + 1}:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Class and Section: ");
            string classAndSection = Console.ReadLine();
            students.Add(new Student { Name = name, ClassAndSection = classAndSection });
        }

        // Manual entry of teachers
        List<Teacher> teachers = new List<Teacher>();
        Console.WriteLine("\nEnter details for 2 teachers:");
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"Enter details for teacher {i + 1}:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Class and Section: ");
            string classAndSection = Console.ReadLine();
            teachers.Add(new Teacher { Name = name, ClassAndSection = classAndSection });
        }

        // Manual entry of subjects
        List<Subject> subjects = new List<Subject>();
        Console.WriteLine("\nEnter details for 2 subjects:");
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"Enter details for subject {i + 1}:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Subject Code: ");
            string subjectCode = Console.ReadLine();
            Console.WriteLine("Select a teacher from the following list:");
            for (int j = 0; j < teachers.Count; j++)
            {
                Console.WriteLine($"{j + 1}. {teachers[j].Name}");
            }
            Console.Write("Enter teacher number: ");
            int teacherIndex = int.Parse(Console.ReadLine()) - 1;
            var teacher = teachers[teacherIndex];
            subjects.Add(new Subject { Name = name, SubjectCode = subjectCode, AssignedTeacher = teacher });
        }

        // Displaying students in a class
        Console.WriteLine("\nStudents in a class:");
        Console.Write("Enter class and section: ");
        string classToDisplay = Console.ReadLine();
        Console.WriteLine($"Students in {classToDisplay}:");
        foreach (var student in students)
        {
            if (student.ClassAndSection == classToDisplay)
            {
                student.Display();
            }
        }

        // Displaying subjects taught by a teacher
        Console.WriteLine("\nSubjects taught by a teacher:");
        Console.WriteLine("Select a teacher from the following list:");
        for (int j = 0; j < teachers.Count; j++)
        {
            Console.WriteLine($"{j + 1}. {teachers[j].Name}");
        }
        Console.Write("Enter teacher number: ");
        int teacherIndexToDisplay = int.Parse(Console.ReadLine()) - 1;
        var teacherToDisplay = teachers[teacherIndexToDisplay];
        Console.WriteLine($"Subjects taught by {teacherToDisplay.Name}:");
        foreach (var subject in subjects)
        {
            if (subject.AssignedTeacher.Name == teacherToDisplay.Name)
            {
                subject.Display();
            }
        }
    }
}