using System;
using Task3.TransportCompany.TypesOfTransport;


namespace Task3.TransportCompany.RealTransport
{
    public class Helicopter : AirTransport
    {
        public Helicopter()
        {
            Console.WriteLine("Helicopter");
        }
        public override string ToString()
        {
            return $"Type Helicopter {base.ToString()}";
        }
    }
}
