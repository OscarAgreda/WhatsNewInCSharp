namespace NullableReferenceTypesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare nullable reference type variables
            string? nullableString = null;
            int? nullableInt = null;

            // Declare non-nullable reference type variables
            string nonNullableString = "hello";
            int nonNullableInt = 123;

            // Attempt to access length of nullable string (will cause a warning)
            int length = nullableString.Length;

            // Check for null before accessing length of nullable string
            if (nullableString != null)
            {
                length = nullableString.Length;
            }

            // Use null-coalescing operator to assign default value to nullable int
            int value = nullableInt ?? 0;

            // Attempt to use non-nullable string in conditional statement (will cause a warning)
            if (nonNullableString == null)
            {
                Console.WriteLine("This should not be possible");
            }

            // Use non-nullable int in arithmetic operation
            int result = nonNullableInt + 456;

            // Output results to console
            Console.WriteLine("Nullable string length: " + length);
            Console.WriteLine("Nullable int value: " + value);
            Console.WriteLine("Non-nullable int result: " + result);
        }
    }
}