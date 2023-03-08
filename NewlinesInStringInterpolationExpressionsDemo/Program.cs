using System;

namespace NewlinesInStringInterpolationExpressionsDemo
{

    // In Example 1, we are demonstrating the use of newlines in a simple string interpolation expression. We declare two variables, name and age, and use them in a string interpolation expression to generate a message. The "\n" escape sequence is used to insert a newline character in the string. The resulting string is then printed to the console using Console.WriteLine().
    // 
    // In Example 2, we are using newlines in a string interpolation expression to generate HTML code. We declare two variables, title and posts, and use them to generate a simple HTML document. The opening HTML tags are included in the string using triple quotes, and the title variable is used in the <title> element. We then use a foreach loop to iterate over the posts array and generate an HTML heading and paragraph element for each post. The closing HTML tags are also included in the string using triple quotes. The resulting HTML code is then printed to the console using Console.WriteLine().
    // 
    // This feature allows developers to easily include newlines in string interpolation expressions without the need for escape characters, which can make the code more readable and maintainable. It is particularly useful when generating multi-line strings such as HTML, XML, or SQL code.
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1 - Simple demonstration of newlines in string interpolation
            string name = "John";
            int age = 30;
            string message = $"Hello {name}!\nYou are {age} years old.";
            Console.WriteLine(message);

            // Example 2 - Using newlines in string interpolation for generating HTML code
            string title = "My Blog";
            string[] posts = new string[] { "First post", "Second post", "Third post" };

            string html = $@"
<!DOCTYPE html>
<html>
    <head>
        <title>{title}</title>
    </head>
    <body>
        <h1>{title}</h1>
";

            foreach (string post in posts)
            {
                html += $@"
        <h2>{post}</h2>
        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
";
            }

            html += @"
    </body>
</html>
";

            Console.WriteLine(html);
        }
    }
}