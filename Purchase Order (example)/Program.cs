using System;
using System.Globalization;
using ConsoleApp9.Entities;
using ConsoleApp9.Entities.Enums;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY):");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");

            Client client = new Client(name, email,  birthDate);
            Order order = new Order(DateTime.Now, status, client);

            int quantity = int.Parse(Console.ReadLine());



            for (int i = 1; i <=2; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string prodName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Product product = new Product(prodName, price);

                Console.Write("Quantity: ");
                int qtde = int.Parse(Console.ReadLine());

                OrderItem orderitem = new OrderItem(qtde, price, product);

                order.AddItem(orderitem);
            }

        }
    }
}
