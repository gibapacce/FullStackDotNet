using System; // Importing the System namespace which provides basic functionality

namespace Recursion // Defining a namespace named Recursion
{
    class Program // Declaring a class named Program
    {
        static void Main(string[] args) // Main method, entry point of the program
        {
            runApp(); // Calling the runApp() method
        }

        // Method to populate an array with student names and initiate printing via recursion
        public static void runApp()
        {
            // Creating an array to hold student names with a length of 10
            string[] students = new string[10];

            // Assigning names to array elements
            students[0] = "Karuna";
            students[1] = "Mark";
            students[2] = "Advaith";
            students[3] = "Sangeeta";
            students[4] = "Nazia";
            students[5] = "Faisal";
            students[6] = "Tania";
            students[7] = "Guru";
            students[8] = "Chandni";
            students[9] = "Kamleshwar";

            int currElem = 0; // Initializing a variable to track the current element being printed
            printViaRecursion(students, currElem); // Initiating printing of the array via recursion
        }

        // Method to print array elements via recursion
        public static void printViaRecursion(string[] arr, int currElem)
        {
            Console.WriteLine(arr[currElem]); // Printing the current element

            // Checking if there are more elements in the array
            if (currElem < arr.Length - 1)
                printViaRecursion(arr, currElem + 1); // Recursively calling the method with the next element index
        }
    }
}
