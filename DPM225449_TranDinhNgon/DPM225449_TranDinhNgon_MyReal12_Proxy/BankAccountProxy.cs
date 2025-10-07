using System;

namespace Proxy.MyRealWorld
{
    public class BankAccountProxy : IBankAccount
    {
        private BankAccount account = new BankAccount();
        private string userRole;

        public BankAccountProxy(string userRole)
        {
            this.userRole = userRole;
        }

        public void Deposit(double amount)
        {
            Console.WriteLine("[Proxy] Logging deposit operation...");
            account.Deposit(amount);
        }

        public void Withdraw(double amount)
        {
            if (userRole != "Admin")
            {
                Console.WriteLine("[Proxy] Withdrawal denied: insufficient permissions.");
                return;
            }
            Console.WriteLine("[Proxy] Logging withdrawal operation...");
            account.Withdraw(amount);
        }

        public double GetBalance()
        {
            Console.WriteLine("[Proxy] Logging balance inquiry...");
            return account.GetBalance();
        }
    }
}