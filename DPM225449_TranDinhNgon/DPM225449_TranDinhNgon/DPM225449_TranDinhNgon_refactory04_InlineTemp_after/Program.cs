using System;

class Order
{
    public double BasePrice() => 1200.0;
}

class Program
{
    bool HasDiscount(Order order)
    {
        return order.BasePrice() > 1000;
    }

    static void Main()
    {
        Order order = new Order();
        Program program = new Program();
        Console.WriteLine("Has discount: " + program.HasDiscount(order));
    }
}