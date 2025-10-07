using System;

namespace Proxy.MyRealWorld
{
    public class BankAccount : IBankAccount
    {
        private double balance;

        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount}, New Balance: {balance}");
        }

        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Insufficient funds.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Withdrew: {amount}, New Balance: {balance}");
            }
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}