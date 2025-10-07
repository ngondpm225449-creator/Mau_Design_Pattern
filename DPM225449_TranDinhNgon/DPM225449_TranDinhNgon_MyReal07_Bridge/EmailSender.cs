using System;

namespace MyRealBridge
{
    // ConcreteImplementor: Gửi thông báo qua Email
    public class EmailSender : INotificationSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"[Email] Đã gửi: {message}");
        }
    }
}