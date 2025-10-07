using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225449_TranDinhNgon_MyReal16_Iterator
{
    public class OrdersIterator : IOrdersIterator
    {
        private OrdersCollection _ordersCollection;
        private int _current = 0;
        private int _step = 1;

        public OrdersIterator(OrdersCollection orders)
        {
            _ordersCollection = orders;
        }

        public Order First()
        {
            _current = 0;
            return _ordersCollection[_current];
        }

        public Order Next()
        {
            _current += _step;
            if (!IsDone)
                return _ordersCollection[_current];
            else
                return null;
        }

        public int Step
        {
            get => _step;
            set => _step = value;
        }

        public Order CurrentOrder => _ordersCollection[_current];

        public bool IsDone => _current >= _ordersCollection.Count;
    }
}
