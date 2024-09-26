using System;
using MyClass;
using MyClass.Arrays;

class Program {
    public static void Main(string[] args) {
        Arrays A = new Arrays(10);

        A.displayArray();

        Sleep.typeOut("Thanks for using.\n", 200);
    }
}