namespace Task3.TransportCompany.TypesOfTransport
{
    public abstract class Transport
    {
        public string CategoryName { get; set; }
        public int Speed { get; set; }
        public int Carrying { get; set; }
        public string Brand { get; set; }
        public int PersonnelCount { get; set; }
        public int PassengersCount { get; set; }

        public override string ToString()
        {
            return $"Speed: {Speed} Carrying: {Carrying} Passengers count: {PassengersCount}";
        }
    }
}
