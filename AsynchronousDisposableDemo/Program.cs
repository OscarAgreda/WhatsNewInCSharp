using System;
using System.Threading.Tasks;

namespace AsynchronousDisposableDemo
{

    // In this code, we have a class called MyDatabaseConnection that implements the new IAsyncDisposable interface. This interface enables the use of the await keyword in the implementation of the DisposeAsync method, allowing us to perform asynchronous cleanup operations when disposing of an object.
    // The MyDatabaseConnection class simulates connecting to and disconnecting from a database with the Connect and Disconnect methods, respectively.The class also has a DisposeAsync method that simulates the process of disposing of the database connection asynchronously, with a delay of 1 second before completing.
    class MyDatabaseConnection : IAsyncDisposable
    {
        // Declare a private bool variable called _disposed
        private bool _disposed = false;

        // Declare a private TaskCompletionSource variable called _disposedTcs
        private TaskCompletionSource<bool> _disposedTcs = new TaskCompletionSource<bool>();

        // Declare a public method called Connect that simulates connecting to a database
        public async Task Connect()
        {
            Console.WriteLine("Connecting to database...");
            await Task.Delay(1000);
            Console.WriteLine("Connected.");
        }

        // Declare a public method called Disconnect that simulates disconnecting from a database
        public async Task Disconnect()
        {
            Console.WriteLine("Disconnecting from database...");
            await Task.Delay(1000);
            Console.WriteLine("Disconnected.");
        }

        // Implement the DisposeAsync method from the IAsyncDisposable interface
        public async ValueTask DisposeAsync()
        {
            // If the object has already been disposed of, return immediately
            if (_disposed)
            {
                return;
            }

            // Set the _disposed flag to true
            _disposed = true;

            // Simulate the process of disposing of the database connection asynchronously
            await Task.Delay(1000);
            Console.WriteLine("Database connection has been disposed of.");

            // Set the result of the _disposedTcs TaskCompletionSource to true
            _disposedTcs.SetResult(true);
        }

        // Declare a finalizer that calls DisposeAsync
        ~MyDatabaseConnection()
        {
            DisposeAsync().ConfigureAwait(false).GetAwaiter().GetResult();
        }
    }

    // Define the main class
    class Program
    {
        // Define the Main method
        static async Task Main(string[] args)
        {
            // In the Main method, we create a new MyDatabaseConnection object and assign it to a variable called connection. We use the using keyword to ensure that the DisposeAsync method is called automatically when the connection object is no longer needed. We then call the Connect method on the connection object and perform some database operations. When the using block is exited, the DisposeAsync method is called asynchronously to dispose of the connection object.
            await using (MyDatabaseConnection connection = new MyDatabaseConnection())
            {
                // Call the Connect method on the connection object
                await connection.Connect();

                // Perform some database operations here

            }

            // At this point, the using statement has automatically disposed of the MyDatabaseConnection object, and the DisposeAsync method has been called and completed asynchronously.
        }
    }
}
