using System;

namespace RequiredMembersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Demo 1: Simple example of using required members
            var user = new User("John", "Doe");
            Console.WriteLine(user);

            // Demo 2: Real-life scenario of using required members
            var order = new Order("123456");
            order.AddItem("Product 1", 10.99m);
            order.AddItem("Product 2", 25.99m);
            Console.WriteLine(order);
        }
    }

    // Demo 1: Simple example of using required members
    public class User
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Email { get; init; }

        public User(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            // Required members must be initialized in the constructor
            Email = $"{firstName.ToLower()}.{lastName.ToLower()}@example.com";
        }

        public override string ToString()
        {
            return $"User: {FirstName} {LastName} ({Email})";
        }
    }

    // Demo 2: Real-life scenario of using required members
    public class Order
    {
        public string OrderNumber { get; init; }
        public DateTime OrderDate { get; init; }
        public string ShippingAddress { get; init; }
        public string BillingAddress { get; init; }

        // Required member: List of order items
        public OrderItem[] Items { get; init; }

        public Order(string orderNumber)
        {
            OrderNumber = orderNumber;

            // Required members must be initialized in the constructor
            OrderDate = DateTime.UtcNow;
            ShippingAddress = "";
            BillingAddress = "";
        }

        public void AddItem(string productName, decimal price)
        {
            if (Items == null)
            {
                // Initialize the required member if not already done
                Items = new OrderItem[0];
            }

            // Add a new item to the list
            var newItem = new OrderItem(productName, price);
            Array.Resize(ref Items, Items.Length + 1);
            Items[Items.Length - 1] = newItem;
        }

        public override string ToString()
        {
            var itemsList = "";
            if (Items != null)
            {
                foreach (var item in Items)
                {
                    itemsList += $"- {item.ProductName} ({item.Price:C})\n";
                }
            }

            return $"Order {OrderNumber}:\n" +
                   $"Date: {OrderDate}\n" +
                   $"Shipping Address: {ShippingAddress}\n" +
                   $"Billing Address: {BillingAddress}\n" +
                   $"Items:\n{itemsList}";
        }
    }

    // Demo 2: Real-life scenario of using required members
    public class OrderItem
    {
        public string ProductName { get; init; }
        public decimal Price { get; init; }

        public OrderItem(string productName, decimal price)
        {
            ProductName = productName;
            Price = price;
        }
    }
}
