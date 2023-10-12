using System;
using Oct6_Assignment;

namespace InterfaceDemo
{
    internal class MainProgram
    {
        static void Main(string[] args)
        {

            Customer c1 = new Customer();
            Console.WriteLine("Enter Customer Name:");
            c1.CustomerName = Console.ReadLine();
            Console.WriteLine("Enter City:");
            c1.City = Console.ReadLine();

            Products p1 = new Products();
            p1.ProdId = 1201;
            Console.WriteLine("Enter Product Name:");
            p1.ProdName = Console.ReadLine();
            Console.WriteLine("Enter Price:");
            p1.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Quantity:");
            p1.Quantity = Convert.ToInt32(Console.ReadLine());

            Order o1 = new Order();
            o1.AddToCart(p1.ProdId, p1.ProdName, p1.Quantity, p1.Price);
           
            int t = o1.calculate(p1.Price, p1.Quantity);
            o1.BookOrder((c1.CustomerId - 2), c1.CustomerName, t);

            Console.Read();
        }
    }
}