using System;
using Task3.TransportCompany.TypesOfTransport;


namespace Task3.TransportCompany.RealTransport
{
    public class Boat : WaterTransport
    {
        public Boat()
        {
            Console.WriteLine("Boat");
        }
        public override string ToString()
        {
            return $"Type Boat {base.ToString()}";
        }
    }
}
