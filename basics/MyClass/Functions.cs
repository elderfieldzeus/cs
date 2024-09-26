using System;
using System.Runtime.InteropServices;
using MyClass;

namespace MyClass.Functions {
    public class Functions {

        public void defaultParameter(int a, int b = 0) {
            CLI.print($"Elements a = {a} and b = {b}\n");
        }

        public void optionalParameter(int a, [Optional] int b) {
            CLI.print($"Elements a = {a} and b = {b}\n");
        }
        
        public void passByRefInt(out int x) {
            x = 5;
        }
    } 
}