namespace MyRealAdapter
{
    // Adaptee: Hệ thống cũ chỉ cung cấp nhiệt độ theo Fahrenheit
    public class FahrenheitSensor
    {
        public double GetFahrenheitTemperature()
        {
            // Giả sử trả về nhiệt độ đo được
            return 98.6;
        }
    }
}