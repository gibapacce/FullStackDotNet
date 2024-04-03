namespace Interfaces;
class Program
{
    static void Main(string[] args)
    {
        runApp();
    }

    static void runApp()
    {
        // Create instances of different classes
        Student student = new Student { Name = "Alice", Age = 20, School = "XYZ School" };
        Teacher teacher = new Teacher { Name = "Bob", Age = 35, Subject = "Math" };
        OfficeStaff staff = new OfficeStaff { Name = "Carol", Age = 25, Department = "Administration" };

        // Display information
        student.DisplayInfo();
        teacher.DisplayInfo();
        staff.DisplayInfo();
    }
}
