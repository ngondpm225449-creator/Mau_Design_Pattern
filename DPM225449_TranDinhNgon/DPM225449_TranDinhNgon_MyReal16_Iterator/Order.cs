using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225449_TranDinhNgon_MyReal16_Iterator
{
    public class Order
    {
        public int OrderId { get; }
        public string CustomerName { get; }
        public double Amount { get; }

        public Order(int id, string customer, double amount)
        {
            OrderId = id;
            CustomerName = customer;
            Amount = amount;
        }
    }
}
