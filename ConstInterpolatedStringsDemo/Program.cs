using System;

namespace ConstInterpolatedStringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1: Simple demonstration of const interpolated strings
            const string name = "Alice";
            const string message = $"Hello, {name}!";

            Console.WriteLine(message);

            // Example 2: Demonstrating the use of const interpolated strings in enterprise-level scenarios
            const string firstName = "John";
            const string lastName = "Doe";
            const string fullName = $"{firstName} {lastName}";

            const string welcomeMessage = "Dear {0}, congratulations on your new job as {1}. We are excited to have you as part of the team!";
            Console.WriteLine(string.Format(welcomeMessage, fullName, "Software Developer"));
        }
    }
}