using System;

namespace ExtendedPropertyPatternsDemo
{

    // In Example 1, we demonstrate the use of extended property patterns with a simple example that shows how to use them to pattern match on an object's properties. In this case, we have an object that is of type string and we use an extended property pattern to match on the Length property and check if it is greater than 5. If the pattern match succeeds, we print a message indicating that the string has more than 5 characters.
    // 
    // In Example 2, we demonstrate the use of extended property patterns in a more enterprise-level scenario. Here, we have a Customer class that contains an Address property, which is itself an object with several properties. We use an extended property pattern to match on the State property of the Address object and check if it is equal to "CA". If the pattern match succeeds, we print a message indicating that the customer lives in California.
    // 
    // In both examples, we use the new extended property pattern syntax, which allows us to specify patterns that match on an object's properties in a concise and readable way. The syntax uses a combination of braces and colons to specify the property name and pattern to match against, respectively.
    // 
    // The use of extended property patterns in these examples highlights how this new feature in C# 10 makes it easier and more efficient to write code that pattern matches on the properties of objects. By allowing us to match on specific properties without having to create a separate variable or access the property through a nested pattern, extended property patterns simplify our code and make it easier to read and maintain.

    class Program
    {
        static void Main(string[] args)
        {
            // Example 1: Simple demonstration of extended property patterns
            object obj = "hello world";
            if (obj is string { Length: > 5 } s)
            {
                Console.WriteLine($"The string '{s}' has more than 5 characters.");
            }

            // Example 2: Enterprise-level demonstration of extended property patterns
            var customer = new Customer
            {
                Name = "John Smith",
                Email = "john.smith@example.com",
                Address = new Address
                {
                    Street = "123 Main St",
                    City = "Anytown",
                    State = "CA",
                    ZipCode = "12345"
                }
            };

            if (customer is { Address: { State: "CA" } })
            {
                Console.WriteLine($"The customer {customer.Name} lives in California.");
            }
        }
    }

    // Simple class to demonstrate extended property patterns
    class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
    }

    // Simple class to demonstrate nested extended property patterns
    class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}