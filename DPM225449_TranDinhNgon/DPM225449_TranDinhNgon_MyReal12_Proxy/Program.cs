using System;

namespace Proxy.MyRealWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IBankAccount proxy = new BankAccountProxy("User");
            proxy.Deposit(500);
            proxy.Withdraw(100); // Should be denied

            IBankAccount adminProxy = new BankAccountProxy("Admin");
            adminProxy.Deposit(1000);
            adminProxy.Withdraw(200); // Should succeed

            Console.WriteLine("Final Balance (Admin): " + adminProxy.GetBalance());

            Console.ReadKey();
        }
    }
}