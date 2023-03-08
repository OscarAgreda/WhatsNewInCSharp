using System;

namespace RecordsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Example1();
            Example2();
            Example3();
            var aa = 5;
        }

        // Example 1: A Simple Record Definition
        private static void Example1()
        {
            Console.WriteLine("Example 1: A Simple Record Definition");

            // Create a new Person record using the record initialization syntax
            Person person = new Person("John", "Doe", 30);

            // Print the record to the console using the default ToString() implementation
            Console.WriteLine(person);

            Console.WriteLine();
        }

        // Example 2: Records for Enterprise-Level Code
        private static void Example2()
        {
            Console.WriteLine("Example 2: Records for Enterprise-Level Code");

            // Create a new Employee record and set its properties
            Employee employee = new Employee
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 30,
                Salary = 50000,
                Department = "Sales"
            };

            // Print the employee to the console using a custom format string
            Console.WriteLine($"Employee: {employee.FirstName} {employee.LastName}, Age {employee.Age}, Salary {employee.Salary:C}, Department {employee.Department}");

            // Create a new Manager record and set its properties
            Manager manager = new Manager
            {
                FirstName = "Jane",
                LastName = "Smith",
                Age = 40,
                Salary = 75000,
                Department = "Marketing",
                Reports = new Employee[]
                {
                    new Employee { FirstName = "Bob", LastName = "Jones", Age = 25, Salary = 40000, Department = "Marketing" },
                    new Employee { FirstName = "Sue", LastName = "Lee", Age = 35, Salary = 55000, Department = "Marketing" },
                    new Employee { FirstName = "Tom", LastName = "Nguyen", Age = 30, Salary = 50000, Department = "Marketing" }
                }
            };

            // Print the manager to the console using a custom format string
            Console.WriteLine($"Manager: {manager.FirstName} {manager.LastName}, Age {manager.Age}, Salary {manager.Salary:C}, Department {manager.Department}, Reports {manager.Reports.Length}");

            Console.WriteLine();
        }

        // Example 3: Records Solve the Boilerplate Code Problem
        private static void Example3()
        {
            Console.WriteLine("Example 3: Records Solve the Boilerplate Code Problem");

            // Create a new Point3D record using the record initialization syntax
            Point3D point1 = new Point3D(1, 2, 3);

            // Create a new Point3D record using the new record syntax
            Point3D point2 = new(1, 2, 3);

            // Print the records to the console
            Console.WriteLine($"point1: {point1}");
            Console.WriteLine($"point2: {point2}");

            Console.WriteLine();
        }
    }

    // Example 1: A Simple Record Definition
    // Define a simple Person record with three properties: FirstName, LastName, and Age
    public record Person(string FirstName, string LastName, int Age);

    // Example 2: Records for Enterprise-Level Code
    // Define an Employee record with five properties: FirstName, LastName, Age, Salary, and Department
    public record Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
    }

    // Define a Manager record that inherits from Employee and adds a Reports property
    public record Manager : Employee
    {
        public Employee[] Reports { get; set; }
    }

    // Example 3: Records Solve the Boilerplate Code Problem
    // Define a Point3D record with three properties: X, Y, and Z
    public record Point3D(int X, int Y, int Z);
}