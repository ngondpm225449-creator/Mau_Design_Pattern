namespace Chain.RealWorld
{
    public class Purchase
    {
        int number;
        double amount;
        string purpose;

        public Purchase(int number, double amount, string purpose)
        {
            this.number = number;
            this.amount = amount;
            this.purpose = purpose;
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public string Purpose
        {
            get { return purpose; }
            set { purpose = value; }
        }
    }
}