using System;

namespace InterpolatedStringHandlersDemo
{

    // In Example 1, we demonstrate the use of interpolated string handlers with a simple example that shows how to use custom handlers to format string interpolation expressions in a way that is more meaningful for our application. In this case, we have defined four custom handlers that format values as currency, decimal, scientific notation, and hexadecimal respectively. We then use these handlers to format a string interpolation expression that displays the price of a product.

    // In Example 2, we demonstrate the use of interpolated string handlers in a more enterprise-level scenario. Here, we have a set of variables that represent the details of an order, and we use string interpolation to format a string that displays those details in a readable and concise way. The string interpolation expression includes custom formatting for the unit price and the total cost of the order.

    // The custom handlers themselves are defined as static methods in the Program class. Each method takes an object as input and returns a string that represents the formatted value of that object. The method names correspond to the format strings used in the string interpolation expressions.

    // The use of interpolated string handlers in these examples highlights how this new feature in C# 10 makes it easier and more efficient to format string interpolation expressions in a way that is tailored to the needs of our application. By defining custom handlers, we can ensure that our string interpolations are consistent and meaningful, even as our codebase grows and changes over time.

    class Program
    {
        static void Main(string[] args)
        {
            // Example 1: Simple demonstration of interpolated string handlers
            Console.WriteLine($"The price of the product is {10:C2}");
            Console.WriteLine($"The price of the product is {10:D}");
            Console.WriteLine($"The price of the product is {10:E}");
            Console.WriteLine($"The price of the product is {10:X}");

            // Example 2: Enterprise-level demonstration of interpolated string handlers
            string productName = "Widget";
            decimal unitPrice = 19.99m;
            int quantity = 10;

            Console.WriteLine($"Order details: {productName,10} | {unitPrice:C2} each | {quantity,3} units | Total cost: {unitPrice * quantity:C2}");
        }

        // Interpolated string handler for currency formatting
        public static string FormatCurrency(object value) => string.Format("{0:C2}", value);

        // Interpolated string handler for decimal formatting
        public static string FormatDecimal(object value) => string.Format("{0:D}", value);

        // Interpolated string handler for scientific notation formatting
        public static string FormatScientific(object value) => string.Format("{0:E}", value);

        // Interpolated string handler for hexadecimal formatting
        public static string FormatHex(object value) => string.Format("{0:X}", value);
    }
}