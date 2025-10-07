using System;

class Program
{
    int quantity = 12;
    double itemPrice = 120.0;

    double CalculateTotal()
    {
        if (BasePrice() > 1000)
        {
            return BasePrice() * 0.95;
        }
        else
        {
            return BasePrice() * 0.98;
        }
    }
    double BasePrice()
    {
        return quantity * itemPrice;
    }

    static void Main()
    {
        Program program = new Program();
        Console.WriteLine("Total: " + program.CalculateTotal());
    }
}