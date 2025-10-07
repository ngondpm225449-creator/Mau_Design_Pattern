using System;

class Program
{
    private string name = "Trần Đinh Ngôn";
    private double amount = 100.0;

    void PrintBanner()
    {
        Console.WriteLine("**************************");
        Console.WriteLine("***** Customer Owes ******");
        Console.WriteLine("**************************");
    }

    double GetOutstanding()
    {
        return amount;
    }

    void PrintOwing()
    {
        this.PrintBanner();

        // Print details.
        Console.WriteLine("name: " + this.name);
        Console.WriteLine("amount: " + this.GetOutstanding());
    }

    static void Main()
    {
        Program program = new Program();
        program.PrintOwing();
    }
}