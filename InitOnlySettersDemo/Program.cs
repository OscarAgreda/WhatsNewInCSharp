using System;

namespace InitOnlySettersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1 - Simple demonstration
            Person p1 = new Person("John", "Doe");
            Console.WriteLine($"Name: {p1.FirstName} {p1.LastName}");

            // Example 2 - Complete demonstration
            Employee e1 = new Employee("Jane", "Doe", "1234", "Developer");
            Employee e2 = new Employee("John", "Doe", "5678", "Manager");
            Console.WriteLine($"Name: {e1.FirstName} {e1.LastName} | ID: {e1.Id} | Title: {e1.Title}");
            Console.WriteLine($"Name: {e2.FirstName} {e2.LastName} | ID: {e2.Id} | Title: {e2.Title}");

            // Example 3 - Importance of init only setters
            Order order = new Order("ABC123", "In Progress");
            Console.WriteLine($"Order Number: {order.OrderNumber} | Status: {order.Status}");
            // order.Status = "Completed"; // Error: Property or indexer 'Order.Status' cannot be assigned to -- it is read only

            Console.WriteLine($"Order Number: {order.OrderNumber} | Status: {order.Status}");
        }
    }

    // Example 1 - Simple demonstration
    public class Person
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

    // Example 2 - Complete demonstration
    public class Employee
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Id { get; }
        public string Title { get; init; }

        private static int nextId = 1;

        public Employee(string firstName, string lastName, string id, string title)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Title = title;
        }

        public Employee(string firstName, string lastName, string title)
            : this(firstName, lastName, $"EMP{nextId}", title)
        {
            nextId++;
        }
    }

    // Example 3 - Importance of init only setters
    public class Order
    {
        public string OrderNumber { get; init; }
        public string Status { get; init; }

        public Order(string orderNumber, string status)
        {
            OrderNumber = orderNumber;
            Status = status;
        }
    }
}
