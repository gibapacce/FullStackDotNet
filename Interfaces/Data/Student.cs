public class Student : IPerson
{
  public string Name { get; set; }
  public int Age { get; set; }
  public string School { get; set; }

  public void DisplayInfo()
  {
    Console.WriteLine($"Student Name: {Name}, Age: {Age}, School: {School}");
  }
}