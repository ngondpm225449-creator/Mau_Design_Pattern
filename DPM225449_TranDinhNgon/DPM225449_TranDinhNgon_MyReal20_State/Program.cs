using  System;

namespace MyReal20State
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Account account = new Account("Nguyen Van A");

            account.Deposit(1000.0);
            account.Deposit(500.0);
            account.PayInterest();
            account.Withdraw(2000.0);
            account.Withdraw(100.0);

            Console.ReadKey();
        }
    }
}
