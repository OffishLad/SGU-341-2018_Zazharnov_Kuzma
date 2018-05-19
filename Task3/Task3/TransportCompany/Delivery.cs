using System;
using System.Collections.Generic;
using System.Text;
using Task3.TransportCompany.TypesOfTransport;
using Task3.TransportCompany.RealTransport;

namespace Task3.TransportCompany
{
    public class Delivery
    {
        private Transport transport;
        private Order order;
        public Delivery()
        {

        }
        public Delivery(Transport transport, Order order)
        {
            Order = order;
            Transport = transport;
        }
        public Transport Transport
        {
            get
            {
                return transport;
            }
            private set
            {
                if (value == null)
                    throw new ArgumentNullException("Transport can't be null");
                transport = value;
            }
        }
        public Order Order
        {
            get
            {
                return order;
            }
            private set
            {
                if (value == null || !value.IsCorrect())
                    throw new ArgumentNullException("Order or order fields can't be null");
                order = value;
            }
        }
        public void Complete()
        {
            Console.WriteLine($"Order was delivered with transport {transport.ToString()}");
        }
    }
}
