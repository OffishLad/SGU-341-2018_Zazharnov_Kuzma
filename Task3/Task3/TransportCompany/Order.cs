using System;

namespace Task3.TransportCompany
{
    public class Order
    {
        private Cargo cargo;
        private string placeOfDelivery;
        public Order()
        {

        }
        public Order(Cargo cargo, string place)
        {
            Cargo = cargo;
            PlaceOfDelivery = place;
        }
        public Cargo Cargo
        {
            get
            {
                return cargo;
            }
            private set
            {
                if (value == null)
                    throw new ArgumentNullException("Cargo can't be empty");
                cargo = value;
            }
        }
        public string PlaceOfDelivery
        {
            get
            {
                return placeOfDelivery;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Place of delivery can't be empty");
                placeOfDelivery = value;
            }
        }
        public bool IsCorrect()
        {
            return cargo != null && !string.IsNullOrEmpty(placeOfDelivery);
        }
    }
}
