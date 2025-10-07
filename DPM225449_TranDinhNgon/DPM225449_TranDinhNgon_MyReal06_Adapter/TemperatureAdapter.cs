using System;

namespace MyRealAdapter
{
    // Adapter: Chuyển đổi từ Fahrenheit sang Celsius
    public class TemperatureAdapter : CelsiusSensor
    {
        private readonly FahrenheitSensor _fahrenheitSensor = new FahrenheitSensor();

        public override double GetTemperature()
        {
            double fahrenheit = _fahrenheitSensor.GetFahrenheitTemperature();
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"Adapter: {fahrenheit}°F = {celsius:0.00}°C");
            return celsius;
        }
    }
}