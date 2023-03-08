using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharp9Demo
{
    // In the first example, we have a simple program that defines a File-local class called Person in the same file as the Program class. The Person class is marked with the private keyword, which indicates that it can only be accessed within the same file. We then create an instance of the Person class and print out its Name property.

    // In the second example, we have a more complex program that defines two File-local classes called Database and Table in the same file as the Program class. The Database class has a collection of Table instances and a method called GetTable that returns a specific Table instance based on its name. The Table class has a collection of rows and a method called AddRow that adds a row to the collection. We then create an instance of the Database class, add a table to it, and add a row to the table. Finally, we print out the number of rows in the table.
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1: Top-level statements
            Console.WriteLine("Hello, world!");
        }
    }
}

namespace CSharp10Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1: Allow const interpolated strings
            const string fullName = "John Doe";
            const string welcomeMessage = $"Hello, {fullName}!";
            Console.WriteLine(welcomeMessage);
        }
    }
}

namespace CSharp11Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1: File-local types
            var person = new Person();
            person.PrintName();

            // Example 2: Required members
            var person2 = new Person2("John Doe");
            Console.WriteLine(person2.Name);
        }
    }

    record Person
    {
        public string FirstName { get; init; } = "John";
        public string LastName { get; init; } = "Doe";

        public void PrintName() => Console.WriteLine($"{FirstName} {LastName}");
    }

    class Person2
    {
        public string Name { get; init; }

        public Person2(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
    }
}