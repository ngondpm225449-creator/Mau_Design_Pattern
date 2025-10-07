using System;

namespace MyRealAdapter
{
    // Target: H? th?ng m?i ch? làm vi?c v?i Celsius
    public class CelsiusSensor
    {
        public virtual double GetTemperature()
        {
            Console.WriteLine("Default CelsiusSensor: always returns 0°C");
            return 0;
        }
    }
}