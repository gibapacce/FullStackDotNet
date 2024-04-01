using System;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            Stack stack = new Stack();

            Console.WriteLine("length of stack=" + stack.getLengthOfStack());
            if (stack.peek() == null)
                Console.WriteLine("Stack contains nothing");
            for (int i = 0; i < 10; i++)
            {
                Node n = new Node();
                n.Data = i.ToString();
                stack.push(n);
                Console.WriteLine("Length of stack=" + stack.getLengthOfStack());
            }

            Node node = stack.pop();
            Console.WriteLine("Popped " + node.Data);

            node = stack.pop();
            Console.WriteLine("Popped " + node.Data);

            Console.WriteLine(stack.listContents());
        }
    }
}

