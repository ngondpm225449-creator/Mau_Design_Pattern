using System;

public class Order
{
    public int Quantity { get; set; } = 10;
    public double ItemPrice { get; set; } = 100.0;

    public double Price()
    {
        return new PriceCalculator(this).Compute();
    }
}

public class PriceCalculator
{
    private double primaryBasePrice;
    private double secondaryBasePrice;
    private double tertiaryBasePrice;

    public PriceCalculator(Order order)
    {
        // Copy relevant information from the order object.
        primaryBasePrice = order.Quantity * order.ItemPrice;
        secondaryBasePrice = Math.Max(0, order.Quantity - 500) * order.ItemPrice * 0.05;
        tertiaryBasePrice = Math.Min(order.Quantity, 100) * order.ItemPrice * 0.1;
    }

    public double Compute()
    {
        // Perform long computation.
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