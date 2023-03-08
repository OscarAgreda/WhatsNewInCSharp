using System;

namespace TargetTypedNewExpressionsDemo
{
    // Define a simple class called Person with two string properties: FirstName and LastName
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Example 1: Creating an object using target-typed new expressions

            // Declare a variable called person and use target-typed new expressions to create a new Person object
            var person = new Person { FirstName = "John", LastName = "Doe" };

            // Print the value of the FirstName and LastName properties of the person object to the console
            Console.WriteLine($"Example 1: {person.FirstName} {person.LastName}");


            // Example 2: Creating an array using target-typed new expressions

            // Use target-typed new expressions to create a new string array
            var names = new[] { "Alice", "Bob", "Charlie" };

            // Print the contents of the names array to the console
            Console.WriteLine($"Example 2: {string.Join(", ", names)}");
        }
    }
}