using System;

namespace cSharpLearning;
public struct Customer
{
    public int Age;
    public string Name;
    public bool IsEmployee;
}

class Program
{
    static void Main(string[] args)
    {
        doApp();
    }

    public static void doApp()
    {
        //int age = 38;
        //string name = "Giba";
        //bool isEmployee = true;
        //Console.ForegroundColor = ConsoleColor.Yellow;
        //Console.WriteLine(name + " is " + age + " years old.");
        //Console.WriteLine("Is he an employee? " + (isEmployee ? "Yes" : "No"));
        //Console.ForegroundColor = ConsoleColor.White;

        Customer cust;
        cust.Age = 35;
        cust.Name = "Giba";
        cust.IsEmployee = false;

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(cust.Name + " is " + cust.Age + " years old.");
        Console.WriteLine("Is he an employee? " + (cust.IsEmployee ? "Yes" : "No"));
        Console.ForegroundColor = ConsoleColor.White;
    }
}
