using System;

namespace PatternMatchSpanDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            // Sample 1: Simple pattern matching on a constant string
            Console.WriteLine("Sample 1: Simple pattern matching on a constant string");

            string message1 = "Hello, world!";
            if (message1.AsSpan() is var span && span.Length >= 5 && span[0] == 'H' && span[1] == 'e' && span[2] == 'l' && span[3] == 'l' && span[4] == 'o')
            {
                Console.WriteLine("The message starts with 'Hello'");
            }
            else
            {
                Console.WriteLine("The message does not start with 'Hello'");
            }

            Console.WriteLine();

            // Sample 2: Pattern matching on a constant string using switch expressions
            Console.WriteLine("Sample 2: Pattern matching on a constant string using switch expressions");

            string input2 = "orange";
            string result2 = input2 switch
            {
                "apple" => "A juicy red apple",
                "orange" => "A sweet and tangy orange",
                "banana" => "A ripe yellow banana",
                _ => "I don't know what that is"
            };

            Console.WriteLine($"Input: {input2}");
            Console.WriteLine($"Result: {result2}");

            Console.ReadKey();

            // Example 3: Switch statement with a Span<char>
            Span<char> word = stackalloc char[] { 'A', 'B', 'C' };
            switch (word)
            {
                case "ABC":
                    Console.WriteLine("Word is \"ABC\"");
                    break;
                case "DEF":
                    Console.WriteLine("Word is \"DEF\"");
                    break;
                default:
                    Console.WriteLine("Word is something else");
                    break;
            }


            // Example 4: Using pattern matching in a method
            Console.WriteLine(Is123("123") ? "Is 123" : "Is not 123");
            Console.WriteLine(Is123("456") ? "Is 123" : "Is not 123");

            // Example 3: Using pattern matching in a method
            static bool Is123(string s)
            {
                return s is "123";
            }

            // Example 5: Pattern matching with switch expressions and ReadOnlySpan<char>
            ReadOnlySpan<char> value = "123";
            int result = value switch
            {
                "1" => 1,
                "2" => 2,
                "123" => 123,
                _ => 0
            };
            Console.WriteLine($"Result: {result}");


            // Example 6: Using pattern matching in an extension method
            ReadOnlySpan<char> first;
            ReadOnlySpan<char> second;
            ReadOnlySpan<char> third;
            var message = "Hello, world!";
            if (message.AsSpan().TrySplit(',', out first, out second, out third))
            {
                Console.WriteLine($"First part: {first.ToString()}");
                Console.WriteLine($"Second part: {second.ToString()}");
                Console.WriteLine($"Third part: {third.ToString()}");
            }
            else
            {
                Console.WriteLine("Could not split the message");
            }

            Console.ReadLine();


            Console.ReadLine();

            //Using pattern matching in a method
            static bool TrySplit(Span<char> span, char separator, out ReadOnlySpan<char> first, out ReadOnlySpan<char> second, out ReadOnlySpan<char> third)
            {
                int index1 = span.IndexOf(separator);
                if (index1 < 0)
                {
                    first = ReadOnlySpan<char>.Empty;
                    second = ReadOnlySpan<char>.Empty;
                    third = ReadOnlySpan<char>.Empty;
                    return false;
                }

                first = span.Slice(0, index1);
                Span<char> remaining = span.Slice(index1 + 1);

                int index2 = remaining.IndexOf(separator);
                if (index2 < 0)
                {
                    second = remaining;
                    third = ReadOnlySpan<char>.Empty;
                    return true;
                }

                second = remaining.Slice(0, index2);
                third = remaining.Slice(index2 + 1);
                return true;
            }
        }
    }




}
