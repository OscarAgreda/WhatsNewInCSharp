namespace UsingDeclarationsDemo
{
    internal class Program
    {
        // Define the Main method
        static void Main(string[] args)
        {
            // Create a new Person object and assign it to a variable called person
            Person person = new Person();

            // Set the Name property of the person object
            person.Name = "John";

            // Call the SayHello method on the person object
            person.SayHello();

            // Create a new file called output.txt and write some text to it
            // we demonstrate the use of Using Declarations with a StreamWriter object that writes some text to a file called "output.txt". We use the using keyword to create the StreamWriter object, and then write some text to the file. When the using block is exited, the StreamWriter object is automatically disposed of and the file is closed.
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("output.txt"))
            {
                file.WriteLine("This is some text that will be written to the file.");
            }

            // At this point, the using statement has automatically disposed of the StreamWriter object and closed the file.

            // Create a new SqlConnection object and assign it to a variable called connection
            // we demonstrate the use of Using Declarations with a SqlConnection object that connects to a database. We use the using keyword to create the SqlConnection object, and then set the ConnectionString property and open the connection. We can perform some database operations here, and then when the using block is exited, the SqlConnection object is automatically disposed of and the database connection is closed.
            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection())
            {
                // Set the ConnectionString property of the connection object
                connection.ConnectionString = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";

                // Open the connection
                connection.Open();

                // Perform some database operations here

            }

            // At this point, the using statement has automatically disposed of the SqlConnection object and closed the database connection.
        }
    }

    // we have a class called Person that has a Name property and a SayHello method that outputs a message to the console. We create a new Person object and assign it to a variable called person, and then set the Name property of the object to "John". We then call the SayHello method on the object to output the message "Hello, my name is John" to the console.
    class Person
    {
        // Declare a public property called Name
        public string Name { get; set; }

        // Declare a public method called SayHello
        public void SayHello()
        {
            Console.WriteLine($"Hello, my name is {Name}");
        }
    }

}