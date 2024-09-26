using System;

class Program {
    public static void Main(string[] args) {
        Console.Write("Enter number: ");
        
        int num;

        if(!int.TryParse(Console.ReadLine(), out num)) {
            Console.WriteLine("Failure to get number");
        }
        else {
            Console.WriteLine($"Your number is {num}...");
        }
    }
}