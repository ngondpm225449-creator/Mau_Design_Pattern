namespace DPM225449_TranDinhNgon_MyReal17_Mediator
{
    public class SupportAgent : User
    {
        public SupportAgent(string name) : base(name) { }

        public override void Receive(string from, string message)
        {
            Console.Write("To Support Agent: ");
            base.Receive(from, message);
        }
    }
}