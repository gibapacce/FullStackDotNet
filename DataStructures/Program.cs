namespace DataStructures;
class Program
{
    static void Main(string[] args)
    {
        arrayApp();
    }

    public static void arrayApp()
    {
        //Data connection
        string[] students3A = new string[10] { "Rahul", "Sheela", "Mukesh", "Afzal", "Ramesh", "Geeta", "Jason", "Robert", "Gopal", "Meera" };
        string[] students3B = new string[10] { "Pinky", "Rakesh", "Rafi", "Mumtaz", "Derek", "Sukhwinder", "Gopi", "Tulsi", "Chandrika", "Ann" };


        string[] subjects = new string[6];
        subjects[0] = "Physics";
        subjects[1] = "Chemistry";
        subjects[2] = "Biology";
        subjects[3] = "Calculus";
        subjects[4] = "Computer Science";
        subjects[5] = "Algebra";

        int[] marks = new int[6];
        marks[0] = 67;
        marks[1] = 90;
        marks[2] = 80;
        marks[3] = 55;
        marks[4] = 71;
        marks[5] = 92;
        // Displaying student names and their subjects with marks
        for (int i = 0; i < students3A.Length; i++)
        {
            Console.WriteLine($"Student: {students3A[i]} (Class 3A)");

            for (int j = 0; j < subjects.Length; j++)
            {
                Console.WriteLine($"   Subject: {subjects[j]}, Mark: {marks[j]}");
            }
        }

        for (int i = 0; i < students3B.Length; i++)
        {
            Console.WriteLine($"Student: {students3B[i]} (Class 3B)");

            for (int j = 0; j < subjects.Length; j++)
            {
                Console.WriteLine($"   Subject: {subjects[j]}, Mark: {marks[j]}");
            }
        }
    }

    

}
