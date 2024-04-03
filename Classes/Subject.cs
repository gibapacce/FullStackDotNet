using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
  public class Subject
  {
    private string name;
    private string shortName;

    public string Name
    {
      get { return name; }
      set { this.name = value; }
    }

    public string ShortName
    {
      get { return shortName; }
      set { shortName = value; }
    }
  }
}
