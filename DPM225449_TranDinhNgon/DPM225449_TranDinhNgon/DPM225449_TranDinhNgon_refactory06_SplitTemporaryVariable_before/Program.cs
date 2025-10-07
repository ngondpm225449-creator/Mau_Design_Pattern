using System;

class Program
{
    double height = 5.0;
    double width = 10.0;

    static void Main()
    {
        Program program = new Program();

        double perimeter = 2 * (program.height + program.width);
        Console.WriteLine(perimeter);

        double area = program.height * program.width;
        Console.WriteLine(area);
    }
}