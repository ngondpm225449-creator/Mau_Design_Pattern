using System;
using System.Collections.Generic;

namespace DPM225449_TranDinhNgon_MyReal16_Iterator
{
    /// <summary>
    /// Iterator Design Pattern - Real world: Orders
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Build a collection of orders
            OrdersCollection orders = new OrdersCollection();
            orders[0] = new Order(1001, "Nguyen Van A", 250000);
            orders[1] = new Order(1002, "Tran Thi B", 350000);
            orders[2] = new Order(1003, "Le Van C", 120000);
            orders[3] = new Order(1004, "Pham Thi D", 520000);
            orders[4] = new Order(1005, "Dang Van E", 780000);

            // Create iterator
            OrdersIterator iterator = orders.CreateIterator();

            // Skip every other order
            iterator.Step = 2;

            Console.WriteLine("Iterating over orders:");
            for (Order order = iterator.First();
                !iterator.IsDone; order = iterator.Next())
            {
                Console.WriteLine($"OrderID: {order.OrderId}, Customer: {order.CustomerName}, Amount: {order.Amount}");
            }

            Console.ReadKey();
        }
    }
}