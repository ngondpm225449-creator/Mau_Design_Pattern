public class GermanyCar : Car
{
    public override void ShowInfo() => Console.WriteLine("Xe ??c");
}

public class GermanyEngine : Engine
{
    public override void ShowInfo() => Console.WriteLine("??ng c? ??c");
}

public class GermanyFactory : CarFactory
{
    public override Car CreateCar() => new GermanyCar();
    public override Engine CreateEngine() => new GermanyEngine();
}
