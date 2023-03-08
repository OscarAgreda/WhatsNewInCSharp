using System;

namespace NullCoalescingAssignmentDemo
{
    // In C#, the internal keyword is an access modifier that specifies that a class or member is only accessible within the same assembly (i.e., the same executable file or library). This means that other assemblies that reference your code cannot access anything that is marked internal.

    // The class keyword is used to define a new class in C#, while the static keyword is used to indicate that a class or member belongs to the type itself, rather than to any specific instance of the type. A static class cannot be instantiated, and can only contain static members.

    // So, the difference between internal class Program and internal static class Program is that the former defines a regular class that can be instantiated and contains instance members, while the latter defines a static class that cannot be instantiated and contains only static members.

    // In the context of a console application like the ones we've been creating, either approach could be used depending on your specific needs. If you don't need a static class and want to be able to create instances of your class, you would use internal class Program. If you only need static members and don't want to be able to create instances of your class, you would use internal static class Program.

    // It's worth noting that the choice between class and static class is independent of the choice between internal and other access modifiers like public or private. You could have a public class or a private static class, for example.

    internal static class Program
    {
        static void Main(string[] args)
        {
            // Example 1: Assigning a default value to a nullable variable

            // Declare a nullable integer variable called myInt
            int? myInt = null;

            // Use the null-coalescing assignment operator to assign a value of 42 to myInt only if it is currently null
            myInt ??= 42;

            // Print the value of myInt to the console
            Console.WriteLine($"Example 1: myInt = {myInt}");


            // Example 2: Updating a variable only if it is currently null

            // Declare a string variable called myString and initialize it to null
            string myString = null;

            // Use the null-coalescing assignment operator to assign a value of "Hello, world!" to myString only if it is currently null
            myString ??= "Hello, world!";

            // Print the value of myString to the console
            Console.WriteLine($"Example 2: myString = {myString}");



        }
    }
}