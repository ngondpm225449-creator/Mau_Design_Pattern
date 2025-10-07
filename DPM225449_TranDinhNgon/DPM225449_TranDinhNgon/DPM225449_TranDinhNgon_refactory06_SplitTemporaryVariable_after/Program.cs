using System;

class Program
{
    static double height = 5.0;
    static double width = 10.0;

    static void Main()
    {
        double perimeter = 2 * (height + width);
        Console.WriteLine(perimeter);

        double area = height * width;
        Console.WriteLine(area);
    }
}