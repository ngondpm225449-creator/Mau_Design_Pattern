using System;

class Program
{
    int Discount(int inputVal, int quantity)
    {
        int result = inputVal;

        if (quantity > 50)
        {
            result -= 2;
        }
        // ... (add more logic if needed)
        return result;
    }

    static void Main()
    {
        Program program = new Program();
        Console.WriteLine("Discounted value: " + program.Discount(100, 60));
    }
}