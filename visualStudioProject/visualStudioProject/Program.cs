using System;

namespace visualStudioProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            string name = CLI.getLine("Hello, what is your name?\nAnswer: ");
            CLI.print("Wow! Your name is, " + name);

            int size = CLI.getInt("\nEnter size of array: ");
            Arrays a = new Arrays(size);
        }
    }
}