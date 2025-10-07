public class JapanCar : Car
{
    public override void ShowInfo() => Console.WriteLine("Xe Nh?t B?n");
}

public class JapanEngine : Engine
{
    public override void ShowInfo() => Console.WriteLine("??ng c? Nh?t B?n");
}

public class JapanFactory : CarFactory
{
    public override Car CreateCar() => new JapanCar();
    public override Engine CreateEngine() => new JapanEngine();
}
