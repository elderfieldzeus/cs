using System;

namespace FirstApp {
    class Sample {
        public static void printHelloWorld() {
            Console.WriteLine("Hello, World");
        }

        public static string getName() {
            Console.Write("Enter your name: ");
            string? name = Console.ReadLine();

            return name ?? string.Empty;
        }

        public static void printName() {
            string name = Sample.getName();
            Console.WriteLine("Hello there, " + name);
        }
    }
}