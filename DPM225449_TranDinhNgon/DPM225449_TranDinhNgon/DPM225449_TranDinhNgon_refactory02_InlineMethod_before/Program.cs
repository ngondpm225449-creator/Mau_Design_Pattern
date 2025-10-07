using System;

class PizzaDelivery
{
    int numberOfLateDeliveries;

    public PizzaDelivery(int lateDeliveries)
    {
        numberOfLateDeliveries = lateDeliveries;
    }

    int GetRating()
    {
        return MoreThanFiveLateDeliveries() ? 2 : 1;
    }

    bool MoreThanFiveLateDeliveries()
    {
        return numberOfLateDeliveries > 5;
    }

    static void Main()
    {
        PizzaDelivery delivery = new PizzaDelivery(7);
        Console.WriteLine("Rating: " + delivery.GetRating());
    }
}