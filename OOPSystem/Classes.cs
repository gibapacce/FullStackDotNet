// Interface for classes that can be displayed
public interface IDisplayable
{
  void Display();
}

// Class representing a student
public class Student : IDisplayable
{
  public string Name { get; set; }
  public string ClassAndSection { get; set; }

  public void Display()
  {
    Console.WriteLine($"Name: {Name}, Class and Section: {ClassAndSection}");
  }
}

// Class representing a teacher
public class Teacher : IDisplayable
{
  public string Name { get; set; }
  public string ClassAndSection { get; set; }

  public void Display()
  {
    Console.WriteLine($"Name: {Name}, Class and Section: {ClassAndSection}");
  }
}

// Class representing a subject
public class Subject : IDisplayable
{
  public string Name { get; set; }
  public string SubjectCode { get; set; }
  public Teacher AssignedTeacher { get; set; }

  public void Display()
  {
    Console.WriteLine($"Name: {Name}, Subject Code: {SubjectCode}, Teacher: {AssignedTeacher.Name}");
  }
}