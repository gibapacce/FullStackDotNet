using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
  public class Student
  {
    private string name;
    private DateTime dateOfBirth;
    private string address;
    private string guardianName;
    private string contactNumber;

    public string Name
    {
      get { return name; }
      set { name = value; }
    }

    public DateTime DateOfBirth
    {
      get { return dateOfBirth; }
      set { dateOfBirth = value; }
    }

    public string Address
    {
      get { return address; }
      set { address = value; }
    }

    public string GuardianName
    {
      get { return guardianName; }
      set { guardianName = value; }
    }

    public string ContactNumber
    {
      get { return contactNumber; }
      set { contactNumber = value; }
    }
  }
}
