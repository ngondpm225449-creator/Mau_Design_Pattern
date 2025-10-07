namespace DPM225449_TranDinhNgon_MyReal17_Mediator
{
    public class User
    {
        private SupportCenter supportCenter;
        private string name;

        public User(string name) => this.name = name;

        public string Name => name;

        public SupportCenter SupportCenter
        {
            get => supportCenter;
            set => supportCenter = value;
        }

        public void Send(string to, string message)
        {
            supportCenter.Send(name, to, message);
        }

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine($"{from} to {Name}: '{message}'");
        }
    }
}