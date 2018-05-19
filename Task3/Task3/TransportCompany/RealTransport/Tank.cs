using System;
using Task3.TransportCompany.TypesOfTransport;


namespace Task3.TransportCompany.RealTransport
{
    public class Tank : LandTransport
    {
        public Tank()
        {
            Console.WriteLine("Tank");
        }

        public override string ToString()
        {
            return $"Type Tank {base.ToString()}";
        }
    }
}
