using System;
using System.IO;
using System.Text;

namespace PrimitiveTypesAndExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //doApp();
            //doAppLoop();
            //doAppDate();
            //doAppStrings();
            //doAppStringBuilder();
            doAppFiles();
        }

        public static void doAppFiles()
        {
            string dir = Directory.GetCurrentDirectory();
            var curDir = Directory.GetCurrentDirectory();
            //C:\Users\labuser\Desktop\GitStudy\PrimitiveTypesAndExpressions\PrimitiveTypesAndExpressions\Program.cs
            string fileName = dir + @"\data.txt";

            if (File.Exists(fileName))
            {
                Console.WriteLine("Yes");
            } else
            {
                Console.WriteLine("No");
            }

            using (StreamWriter wrt = File.CreateText(fileName))
            {
                wrt.WriteLine("Hello from inside the text file");
                wrt.WriteLine("Help me out!");
                wrt.Close();
            }

            string[] lines = File.ReadAllLines(fileName);
            foreach (var item in lines)
            {
                Console.WriteLine(item);
            }

            string allText = File.ReadAllText(fileName);
            Console.WriteLine(allText);

            File.Delete(fileName);
        }

        static public void doAppStringBuilder()
        {
            string example = "256 Aldonei, Vitor, Michael, Issac";

            StringBuilder sb = new StringBuilder(example);
            sb.Append("Hello not using extra memory");
            sb.Clear();

            sb.Append(example.Insert(0, " Hello not using extra memory "));
            sb.Clear();

            sb.Append(example);
            sb.AppendFormat(" a new {0} string", "NEW STRING VALUE");

            Console.WriteLine(sb.ToString());

            foreach (var item in sb.ToString().Split(" "))
            {
                Console.WriteLine(item + "'");
            }

        }

        static public void doAppStrings()
        {
            string example = "256 Aldonei, Vitor, Michael, Issac";

            Console.WriteLine(example.Length);
            Console.WriteLine(example.Contains("O", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine(example.Contains("A"));
            Console.WriteLine(example.Contains("O".ToLower()));
            Console.WriteLine(example.Contains("o".ToUpper()));
            
            Console.WriteLine(example.Contains("T"));
            Console.WriteLine(example.EndsWith("T"));
            Console.WriteLine(example.Insert(0, "LLL"));
            Console.WriteLine(example.Insert(1, "LLL"));
            Console.WriteLine(example.Insert(example.IndexOf("V"),"LLL"));
            example = example.Insert(example.IndexOf("V"), "X");
            Console.WriteLine(example.Insert(example.IndexOf("X"), "LLL"));
        }

        static public void doAppDate()
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.ToString());

            Console.WriteLine(dt.ToString("d"));
            Console.WriteLine(dt.ToString("D"));
            Console.WriteLine(dt.ToString("F"));
            Console.WriteLine(dt.ToString("dd/mm/yyyy"));
            Console.WriteLine(dt.ToString("dd/MM/yyyy"));
            Console.WriteLine(dt.ToString("dd/M/yyyy"));

            DateTime date1 = new DateTime(2019, 3, 4, 14, 0, 15);
            DateTime date2 = new DateTime(2019, 3, 4, 4, 0, 15);
            TimeSpan value = date1.Subtract(date2);

            Console.WriteLine("Difference between two date is {0} hours", value.TotalSeconds);
        }

        static public void doAppLoop()
        {
            int x = 10;

            if (x >= 10)
            {
                Console.WriteLine("Inside case 10");
                switch (x)
                {
                    case 9:
                        Console.WriteLine("Inside case 9");
                        break;
                    case 11:
                        Console.WriteLine("Inside case 11");
                        break;
                }
            }

            while (x < 20)
            {
                x++;
            }
            do
            {
                x--;
            } while (x >= 10);
            for (int i = 0; i <= x; i++)
            {
                if (i == 1000) ;
                {
                    break;
                }
            }

            string[] numbers = { "1", "2", "3", "4", "5", "6" };

            foreach (var item in numbers)
            {
                
            }
        }

        

        static public void doApp()
        {
            bool xBool = true;
            xBool = Convert.ToBoolean(1);

            byte xByte = 250;
            sbyte xSbyte = -100;

            char xChar = 'a';
            
            decimal xDecimal = 87.9M;

            double xDouble = 87.9;

            float xFloat = 87.9F;

            int xInt = 1234567890;

            long xLong = 1234567890123456789;

            ulong xUlong = 12345678901234567890;


            string xString = "HelloWorld";
            if (xString == "HelloWorld")
            {
                Console.WriteLine("Comparator");
            }

            if (xString == "HelloWorldd" || xInt < 300)
            {
                Console.WriteLine("Comparator 2");
            }

            if (xString == "HelloWorldd" && xInt < 300)
            {
                Console.WriteLine("Comparator 3");
            }
        }

    }
}
