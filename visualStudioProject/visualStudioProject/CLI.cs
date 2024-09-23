using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visualStudioProject
{
    public class CLI
    {
        public static void print(string message)
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

            int line = Convert.ToInt32(Console.ReadLine());

            return line;
        }

        public static int getInt()
        {
            int line = Convert.ToInt32(Console.ReadLine());

            return line;
        }
    }
}
