using System;

namespace Phase1Section4._21
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            string[] students = new string[10];
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

            bool flag = true;
            string temp;
            int numLength = students.Length;
            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (students[j + 1].CompareTo(students[j]) < 0 )
                    {
                        temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;
                        flag = true;
                    }
                }
            }

         
            foreach (string s in students)
            {
                Console.WriteLine(s);
            }
        }
    }
}
