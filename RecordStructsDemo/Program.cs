using System;

namespace RecordStructsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1: Creating a simple record struct
            var person = new Person("John", "Doe", 25);
            Console.WriteLine(person);

            // Example 2: Using record structs with deconstruction
            var (firstName, lastName, age) = person;
            Console.WriteLine($"First name: {firstName}, Last name: {lastName}, Age: {age}");
        }
    }

    // Example 1: Creating a simple record struct
    public record Person(string FirstName, string LastName, int Age);

    // Example 2: Using record structs with deconstruction
    public record Employee(string FirstName, string LastName, string Title)
    {
        public void Deconstruct(out string firstName, out string lastName, out string title)
        {
            firstName = FirstName;
            lastName = LastName;
            title = Title;
        }
    }
}