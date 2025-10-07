using System;

class Program
{
    int quantity = 12;
    double itemPrice = 120.0;

    double CalculateTotal()
    {
        double basePrice = quantity * itemPrice;

        if (basePrice > 1000)
        {
            return basePrice * 0.95;
        }
        else
        {
            return basePrice * 0.98;
        }
    }

    static void Main()
    {
        Program program = new Program();
        Console.WriteLine("Total: " + program.CalculateTotal());
    }
}