using System;
using Task3.TransportCompany.TypesOfTransport;


namespace Task3.TransportCompany.RealTransport
{
    public class UnderwaterBoat : WaterTransport
    {
        public UnderwaterBoat()
        {
            Console.WriteLine("UnderwaterBoat");
        }
        public override string ToString()
        {
            return $"Type UnderwaterBoat {base.ToString()}";
        }
    }
}
