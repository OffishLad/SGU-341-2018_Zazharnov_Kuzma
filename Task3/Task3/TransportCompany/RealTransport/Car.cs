using System;
using Task3.TransportCompany.TypesOfTransport;


namespace Task3.TransportCompany.RealTransport
{
    public class Car : LandTransport
    {
        public Car()
        {
            Console.WriteLine("Car");
        }
        public override string ToString()
        {
            return $"Type Car {base.ToString()}";
        }
    }
}
