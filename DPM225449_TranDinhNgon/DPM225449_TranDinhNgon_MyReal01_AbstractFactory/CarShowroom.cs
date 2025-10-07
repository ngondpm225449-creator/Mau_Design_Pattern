public class CarShowroom
{
    private readonly Car _car;
    private readonly Engine _engine;

    public CarShowroom(CarFactory factory)
    {
        _car = factory.CreateCar();
        _engine = factory.CreateEngine();
    }

    public void Show()
    {
        _car.ShowInfo();
        _engine.ShowInfo();
    }
}
