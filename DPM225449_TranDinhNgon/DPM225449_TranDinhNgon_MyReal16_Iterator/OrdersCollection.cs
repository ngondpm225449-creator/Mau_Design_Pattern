using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225449_TranDinhNgon_MyReal16_Iterator
{
    public class OrdersCollection : IOrdersCollection
    {
        private List<Order> orders = new List<Order>();

        public OrdersIterator CreateIterator()
        {
            return new OrdersIterator(this);
        }

        public int Count => orders.Count;

        // Indexer
        public Order this[int index]
        {
            get => orders[index];
            set => orders.Add(value);
        }
    }
}
