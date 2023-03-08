using System.Runtime.CompilerServices;

namespace CallerArgumentExpressionDemo
{


    // The CallerArgumentExpression attribute is a new feature in C# 10 that allows you to customize the behavior of caller argument expressions. This can be useful in scenarios where you need to validate or manipulate input parameters in a method.
    // 
    // In example 1, we have a simple demonstration of the CallerArgumentExpression attribute. We define a method called SimpleDemo that takes a string parameter called message. We apply the [CallerArgumentExpression("message")] attribute to the parameter, which tells the compiler to substitute the parameter name message for any argument that is passed to the method. We also use the [MethodImpl(MethodImplOptions.NoInlining)] attribute to ensure that the compiler generates the expected caller information for the CallerArgumentExpression attribute. Inside the method, we simply print the value of the message parameter to the console.
    // 
    // In example 2, we have a more complex demonstration of the CallerArgumentExpression attribute in an enterprise-level scenario. We define a method called EnterpriseDemo that takes two string parameters called firstName and lastName, and we apply the [CallerArgumentExpression("firstName")] attribute to the third parameter, which is used to specify the name of the argument that is passed to the method. This allows us to customize the error message that is thrown if the firstName argument is invalid. Inside the method, we use the firstName and lastName parameters to create a full name string, which we then print to the console.
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1: Simple demonstration of CallerArgumentExpression attribute
            SimpleDemo("Hello world!");

            // Example 2: Demonstration of using CallerArgumentExpression in an enterprise-level scenario
            EnterpriseDemo("John", "Doe");
        }

        // Example 1: Simple demonstration of CallerArgumentExpression attribute
        [MethodImpl(MethodImplOptions.NoInlining)]
        static void SimpleDemo([CallerArgumentExpression("message")] string message = "")
        {
            Console.WriteLine($"Message: {message}");
        }

        // Example 2: Demonstration of using CallerArgumentExpression in an enterprise-level scenario
        static void EnterpriseDemo(string firstName, string lastName, [CallerArgumentExpression("firstName")] string argName = "")
        {
            // Example: validate first name argument using CallerArgumentExpression
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentException("First name cannot be null or whitespace.", argName);
            }

            // Example: combine first and last name arguments using CallerArgumentExpression
            string fullName = $"{firstName} {lastName}";

            Console.WriteLine($"Full Name: {fullName}");
        }
    }
}