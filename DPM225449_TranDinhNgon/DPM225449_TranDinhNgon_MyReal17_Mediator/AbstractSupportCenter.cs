namespace DPM225449_TranDinhNgon_MyReal17_Mediator
{
    public abstract class AbstractSupportCenter
    {
        public abstract void Register(User user);
        public abstract void Send(string from, string to, string message);
    }
}