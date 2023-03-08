using System;

namespace AutoDefaultStructsDemo
{

    // This program demonstrates the new feature in C# 11 called "Auto-default structs". This feature allows structs to be created without explicitly specifying a value for each member, with the members being automatically initialized to their default values.
    // Example 1 is a simple usage of this feature. We create a struct instance with auto-default members and print the default values of each member.
    // Example 2 is a real-life scenario that demonstrates how auto-default structs can simplify and improve the readability of code. We create an array of structs with auto-default members, assign values to some of the struct instances, and print them out. Since the remaining struct instances are automatically initialized to their default values, we don't have to explicitly specify a value for each member, making the code more concise and easier to read.

    class Program
    {
        static void Main(string[] args)
        {
            Example1();
            Example2();
        }

        // Example 1 - Simple usage
        // This example demonstrates the simplicity of creating a struct instance with 
        // automatically initialized members without explicitly specifying values for each member.
        static void Example1()
        {
            // Create a struct with auto-default members
            MyStruct myStruct = new();

            // Print the default values
            Console.WriteLine($"myStruct.Id: {myStruct.Id}");
            Console.WriteLine($"myStruct.Name: {myStruct.Name}");
            Console.WriteLine($"myStruct.Price: {myStruct.Price}");
        }

        // Example 2 - Real-life scenario
        // This example demonstrates how auto-default structs can simplify and improve the readability 
        // of code in a real-life scenario.
        static void Example2()
        {
            // Create an array of structs with auto-default members
            MyStruct[] myStructs = new MyStruct[3];

            // Assign values to the struct instances
            myStructs[0].Id = 1;
            myStructs[0].Name = "Product A";
            myStructs[0].Price = 10.99m;

            myStructs[1].Id = 2;
            myStructs[1].Name = "Product B";
            myStructs[1].Price = 5.99m;

            // Print the struct instances
            foreach (var myStruct in myStructs)
            {
                Console.WriteLine($"Id: {myStruct.Id}");
                Console.WriteLine($"Name: {myStruct.Name}");
                Console.WriteLine($"Price: {myStruct.Price}");
                Console.WriteLine();
            }
        }
    }

    // Define a struct with auto-default members
    public struct MyStruct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
