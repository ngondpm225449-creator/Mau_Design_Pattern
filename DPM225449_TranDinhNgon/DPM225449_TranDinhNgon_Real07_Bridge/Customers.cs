using System;

namespace Bridge.RealWorld
{
    public class Customers : CustomersBase
    {
        public override void ShowAll()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------");
            base.ShowAll();
            Console.WriteLine("------------------------");
        }
    }
}