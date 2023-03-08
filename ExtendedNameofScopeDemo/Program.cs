using System;

namespace ExtendedNameofScopeDemo
{
    //the "Extended nameof scope" feature allows the nameof operator to be used with more types of expressions. This means that developers can use nameof to easily reference specific members or types in their code without having to worry about typing errors or having to manually update their code when things change. For example, if you have a method with a parameter, you can use nameof to get the name of the parameter as a string. This makes your code more concise and less error-prone.

    //Prior to C# 11, nameof was only allowed to be used with certain types of expressions, such as variable names, types, or public members. However, with the introduction of the Extended nameof scope feature, the nameof operator can now be used with more types of expressions, such as:
    // Tuple element names
    // Namespace names
    // Method names
    // Property names
    // Event names
    // Enum values
    // Generic type parameters and their constraints
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1: Using extended nameof with a property
            // The Person class has three properties: FirstName, LastName, and Age. By using nameof, we can obtain the name of each property as a string without hardcoding it, making our code more flexible and easier to maintain. In this example, we create a new Person object, set its properties, and then use nameof to obtain the name of each property and print it to the console.
            Console.WriteLine("Example 1: Using extended nameof with a property");

            var person = new Person
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 30
            };

            Console.WriteLine($"First name property name: {nameof(person.FirstName)}");
            Console.WriteLine($"Last name property name: {nameof(person.LastName)}");
            Console.WriteLine($"Age property name: {nameof(person.Age)}");

            Console.WriteLine();

            // Example 2: Using extended nameof with a method
            //  The Calculator class has a single Add method that takes two integers as arguments and returns their sum. By using nameof, we can obtain the name of the method as a string without hardcoding it, making our code more flexible and easier to maintain. In this example, we create a new Calculator object, call its Add method to add two numbers, and then use nameof to obtain the name of the method and print it to the console.
            Console.WriteLine("Example 2: Using extended nameof with a method");

            var calculator = new Calculator();
            var result = calculator.Add(3, 4);

            Console.WriteLine($"Method name: {nameof(calculator.Add)}");
            Console.WriteLine($"Result: {result}");
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}