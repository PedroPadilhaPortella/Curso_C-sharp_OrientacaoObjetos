using System;
using System.Globalization;
using Pedidos.Entities;
using Pedidos.Entities.Enums;

namespace Pedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name:");
            string clientName = Console.ReadLine();
            Console.Write("Email:");
            string clientEmail = Console.ReadLine();
            Console.Write("BirthDate (DD/MM/YYYY):");
            DateTime clientBirth = DateTime.Parse(Console.ReadLine());
            Console.Write("Status Order: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            
            Client client = new Client(clientName, clientEmail, clientBirth);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items in this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Enter #{i} item data\nProduct Name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(productQuantity, productPrice, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine("\nORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}
