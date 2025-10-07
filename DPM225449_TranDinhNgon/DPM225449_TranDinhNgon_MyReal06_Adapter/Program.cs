using System;

namespace MyRealAdapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CelsiusSensor sensor = new TemperatureAdapter();
            double temp = sensor.GetTemperature();

            Console.WriteLine($"Nhiệt độ hiện tại (Celsius): {temp:0.00}°C");
            Console.ReadKey();
        }
    }
}
