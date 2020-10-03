using System;
using System.Globalization;
using System.Xml;
using Project2.Entities;
using Project2.Entities.Enums;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ENTER CLIENT DATA: " );
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("ENTER ORDER DATA: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            Client client = new Client(name,email,birthDate);
            Order order = new Order(DateTime.Now ,status,client);



            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("ENTER #" + (i+1) + " ITEM DATA: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Product product = new Product(productName,price);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                OrderItem orderItem = new OrderItem(quantity,price,product);
                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order);
            



        }
    }
}
