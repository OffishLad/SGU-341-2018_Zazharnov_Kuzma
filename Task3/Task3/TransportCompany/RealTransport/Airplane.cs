using System;
using Task3.TransportCompany.TypesOfTransport;

namespace Task3.TransportCompany.RealTransport
{
    public class Airplane : AirTransport
    {
        public Airplane()
        {
            Console.WriteLine("Airplane");
        }

        public override string ToString()
        {
            return $"Type Airplane {base.ToString()}";
        }
    }
}
