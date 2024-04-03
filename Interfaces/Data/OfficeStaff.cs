public class OfficeStaff : IPerson
{
  public string Name { get; set; }
  public int Age { get; set; }
  public string Department { get; set; }

  public void DisplayInfo()
  {
    Console.WriteLine($"Office Staff Name: {Name}, Age: {Age}, Department: {Department}");
  }
}