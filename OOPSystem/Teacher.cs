using System;

namespace OOPSystem
{
  public class Teacher
  {
    public string Name { get; set; }
    public string ClassAndSection { get; set; }

    public Teacher(string name, string classAndSection)
    {
      Name = name;
      ClassAndSection = classAndSection;
    }
  }
}
