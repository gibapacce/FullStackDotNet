public class Teacher : IPerson
{
  public string Name { get; set; }
  public int Age { get; set; }
  public string Subject { get; set; }

  public void DisplayInfo()
  {
    Console.WriteLine($"Teacher Name: {Name}, Age: {Age}, Subject: {Subject}");
  }
}