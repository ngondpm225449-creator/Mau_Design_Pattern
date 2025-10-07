using System;

public class Order
{
    // Example fields for demonstration
    public int Quantity { get; set; } = 10;
    public double ItemPrice { get; set; } = 100.0;

    public double Price()
    {
        return new OrderPriceCalculator(this).Compute();
    }
}

public class OrderPriceCalculator
{
    private readonly Order _order;

    public OrderPriceCalculator(Order order)
    {
        _order = order;
    }

    public double Compute()
    {
        double primaryBasePrice = _order.Quantity * _order.ItemPrice;
        double secondaryBasePrice = Math.Max(0, _order.Quantity - 500) * _order.ItemPrice * 0.05;
        double tertiaryBasePrice = Math.Min(_order.Quantity, 100) * _order.ItemPrice * 0.1;

        // Example long computation
        return primaryBasePrice + secondaryBasePrice + tertiaryBasePrice;
    }
}

class Program
{
    static void Main()
    {
        Order order = new Order();
        Console.WriteLine("Order price: " + order.Price());
    }
}