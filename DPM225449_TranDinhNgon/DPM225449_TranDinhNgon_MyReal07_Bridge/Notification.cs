namespace MyRealBridge
{
    // Abstraction: Định nghĩa lớp thông báo
    public class Notification
    {
        protected INotificationSender sender;

        public Notification(INotificationSender sender)
        {
            this.sender = sender;
        }

        public virtual void Send(string message)
        {
            sender.SendMessage(message);
        }
    }
}