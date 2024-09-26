using System;
using System.Threading;
using MyClass;

namespace MyClass { 
    public class Sleep {
        public static void sleep(int ms) {
            Thread.Sleep(ms);
        }

        public static void typeOut(string text, int ms) {
            for(int i = 0; i < text.Length; i++) {
                CLI.print(text[i]);
                sleep(ms);
            }
        }
    }
}