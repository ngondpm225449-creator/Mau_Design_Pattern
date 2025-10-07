using System;

namespace MyRealBridge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Gửi thông báo qua Email
            Notification emailNotification = new Notification(new EmailSender());
            emailNotification.Send("Xin chào qua Email!");

            // Gửi thông báo qua SMS
            Notification smsNotification = new Notification(new SmsSender());
            smsNotification.Send("Xin chào qua SMS!");

            Console.ReadKey();
        }
    }
}
