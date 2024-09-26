using System;

namespace MyClass {
    public class CLI
    {
        public static void print(string message)
        {
            Console.Write(message);
        }

        public static void print(char message)
        {
            Console.Write(message);
        }

        public static void print(int message)
        {
            Console.Write(message);
        }

        public static string getLine(string message)
        {
            print(message);

            string? line = Console.ReadLine();

            return line ?? string.Empty;
        }

        public static string getLine()
        {
            string? line = Console.ReadLine();

            return line ?? string.Empty;
        }

        public static int getInt(string message)
        {
            print(message);
            
            int line = -1;

            try {
                line = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception e) {
                print("Try again!\n");
            }
            

            return line;
        }

        public static int getInt()
        {
            int line = Convert.ToInt32(Console.ReadLine());

            return line;
        }
    }
}