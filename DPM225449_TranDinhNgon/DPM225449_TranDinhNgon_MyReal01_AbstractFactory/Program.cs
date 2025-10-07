class Program
{
    static void Main()
    {
        CarFactory japanFactory = new JapanFactory();
        CarShowroom japanShowroom = new CarShowroom(japanFactory);
        japanShowroom.Show();

        CarFactory germanyFactory = new GermanyFactory();
        CarShowroom germanyShowroom = new CarShowroom(germanyFactory);
        germanyShowroom.Show();

        Console.ReadKey();
    }
}
