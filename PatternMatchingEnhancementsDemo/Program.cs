using System;

namespace PatternMatchingEnhancementsDemo
{

    // Sample 1: Matching on property of an object
    // We define a Person class with two properties: FirstName and LastName
    // In the Main method, we create a new instance of the Person class with the first name "John" and last name "Doe".
    // We use the new syntax for pattern matching to match on the FirstName property of the person object. This syntax checks whether the person object is not null, and if it has the FirstName property with the value "John".
    // We use the result of the pattern match to print a message to the console.

    // Sample 2: Using switch pattern to handle multiple cases
    // We define an abstract Shape class and three derived classes: Circle, Rectangle, and Square.
    // In the Main method, we create a new instance of the Circle class with a radius of 5.
    // We use the new syntax for switch pattern matching to calculate the area of the shape object. The switch statement checks whether the shape object is a Circle, Rectangle, or Square, and assigns the corresponding property values to local variables.
    // We use the area formula for each shape to calculate the area, and return the result.
    // Overall, these two samples demonstrate the power of the pattern matching enhancements feature in C# 9, which allows for more concise and readable code in handling complex conditional logic.

    class Program
    {
        static void Main(string[] args)
        {
            // Example 1: Matching on property of an object
            Console.WriteLine("Example 1: Matching on property of an object\n");

            Person person = new Person("John", "Doe");

            if (person is { FirstName: "John" })
            {
                Console.WriteLine("First name is John.");
            }
            else
            {
                Console.WriteLine("First name is not John.");
            }

            Console.WriteLine();

            // Example 2: Using switch pattern to handle multiple cases
            Console.WriteLine("Example 2: Using switch pattern to handle multiple cases\n");

            Shape shape = new Circle(5);

            double area = CalculateArea(shape);

            Console.WriteLine($"The area of the {shape.GetType().Name} is {area}");
        }

        private static double CalculateArea(Shape shape)
        {
            double area = shape switch
            {
                Circle { Radius: var r } => Math.PI * r * r,
                Rectangle { Width: var w, Height: var h } => w * h,
                Square { Side: var s } => s * s,
                _ => throw new ArgumentException(message: "Invalid shape type", paramName: nameof(shape))
            };

            return area;
        }
    }

    public class Person
    {
        public string FirstName { get; }
        public string LastName { get; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

    public abstract class Shape { }

    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }
    }

    public class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
    }

    public class Square : Shape
    {
        public double Side { get; }

        public Square(double side)
        {
            Side = side;
        }
    }
}
