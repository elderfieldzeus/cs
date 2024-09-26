using System;
using MyClass;
using MyClass.Arrays;
using MyClass.Functions;

class Program {
    public static void Main(string[] args) {
        Arrays A = new Arrays(5);
        Functions F = new Functions();

        A.displayArray();

        F.defaultParameter(A.getElemByIndex(0));
        F.optionalParameter(A.getElemByIndex(1));
        
        int x;
        F.passByRefInt(out x);

        CLI.print($"x is now {x}\n");

        Sleep.typeOut("Thanks for using.\n", 200);
        CLI.getLine();
    }
}