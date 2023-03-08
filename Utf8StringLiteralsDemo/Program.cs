using System;

namespace Utf8StringLiteralsDemo
{

    // The UTF-8 string literals feature is a new feature in C# 11 that allows string literals to be encoded in UTF-8, making it easier to handle internationalization and localization.
    // 
    // In example 1, we have a demonstration of a simple UTF-8 string literal. We define a string variable called utf8String and assign it the value "Hello, world! 🌎". The string contains the 🌎 emoji, which is encoded using UTF-8. We then use the Console.WriteLine() method to print the string to the console.
    // 
    // In example 2, we have a demonstration of a UTF-8 string literal with an escape sequence. We define a string variable called utf8StringWithEscape and assign it the value "\u0068\u0065\u006C\u006C\u006F, world! \U0001F310". The escape sequences \u0068, \u0065, \u006C, and so on, represent the characters h, e, l, and so on, respectively, in the string "Hello, world!". The escape sequence \U0001F310 represents the 🌐 emoji, which is also encoded using UTF-8. We then use the Console.WriteLine() method to print the string to the console.
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1: Simple UTF-8 string literal
            string utf8String = "Hello, world! 🌎";
            Console.WriteLine(utf8String);

            // Example 2: UTF-8 string literal with escape sequence
            string utf8StringWithEscape = "\u0068\u0065\u006C\u006C\u006F, world! \U0001F310";
            Console.WriteLine(utf8StringWithEscape);
        }
    }
}