using System;

namespace MyRealBridge
{
    // ConcreteImplementor: Gửi thông báo qua SMS
    public class SmsSender : INotificationSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"[SMS] Đã gửi: {message}");
        }
    }
}