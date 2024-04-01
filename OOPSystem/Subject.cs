using System;

namespace OOPSystem
{
  public class Subject
  {
    public string Name { get; set; }
    public string SubjectCode { get; set; }
    public Teacher Teacher { get; set; }

    public Subject(string name, string subjectCode, Teacher teacher)
    {
      Name = name;
      SubjectCode = subjectCode;
      Teacher = teacher;
    }
  }
}
