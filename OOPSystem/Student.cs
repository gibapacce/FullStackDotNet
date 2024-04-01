using System;

namespace OOPSystem
{
  public class Student
  {
    public string Name { get; set; }
    public string ClassAndSection { get; set; }

    public Student(string name, string classAndSection)
    {
      Name = name;
      ClassAndSection = classAndSection;
    }
  }
}
