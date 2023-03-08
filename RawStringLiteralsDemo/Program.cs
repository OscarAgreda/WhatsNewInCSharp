using System;

namespace RawStringLiteralsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1: Simple demonstration of Raw string literals
            SimpleDemo();

            // Example 2: Demonstration of using Raw string literals in a real-life scenario
            EnterpriseDemo();
        }

        // Example 1: Simple demonstration of Raw string literals
        static void SimpleDemo()
        {
            // Example: Create a string with a line break using a Raw string literal
            string message = @"Hello,
                                world!";
            Console.WriteLine(message);
        }

        // Example 2: Demonstration of using Raw string literals in a real-life scenario
        static void EnterpriseDemo()
        {
            // Example: Read a SQL query from a Raw string literal
            string query = @"
                SELECT *
                FROM Customers
                WHERE Country = 'USA'
            ";
            Console.WriteLine(query);
        }
    }
}