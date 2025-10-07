namespace DPM225449_TranDinhNgon_MyReal17_Mediator
{
    public class Customer : User
    {
        public Customer(string name) : base(name) { }

        public override void Receive(string from, string message)
        {
            Console.Write("To Customer: ");
            base.Receive(from, message);
        }
    }
}