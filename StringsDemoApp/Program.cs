using System.Text;

namespace StringsDemoApp;
class Program
{
    static void Main(string[] args)
    {
        char charA = 'a';
        //char.ToUpper(charA); 
        //char.ToLower(charA);

        //Escape Sequence:
        // '\n' -- New line
        // '\t' -- tab
        //  \\  -- backslash 

        string name = "Giba";
        Console.WriteLine(name);

        StringBuilder builder = new StringBuilder();

        // Append the first part of the sequence
        builder.Append("My name is ").Append(name).Append(".\n");

        // Append the second part of the sequence
        builder.Append("I am a developer.");

        // Convert StringBuilder to string and output
        string sentence = builder.ToString();
        Console.WriteLine(sentence);


        //String Formatting:

        Console.Write("\nWhat is your name? ");
        string userName = Console.ReadLine();
        Console.Write("\nWhat is your age? ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(string.Format("\nHello {0}, how are you doing?\nAs you said, you are {1} years old.", userName, age));
        Console.WriteLine();


    }
}
