namespace Task2
{
    public class Man
    {
        private string name;
        private int age;
        private int growth;
        private int weight;

        public Man(string name, int age, int growth, int weight)
        {
            Name = name;
            Age = age;
            Growth = growth;
            Weight = weight;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value) && value.Length > 1479)
                {
                    throw new System.ArgumentNullException("Name can't be null");
                }
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0 && value > 123)
                {
                    throw new ExceedingTheAllowedValue("Unacceptable age");
                }
                age = value;
            }
        }
        public int Growth
        {
            get
            {
                return growth;
            }
            set
            {
                if (value < 20 && value > 350)
                {
                    throw new ExceedingTheAllowedValue("Unacceptable growth");
                }
                growth = value;
            }
        }
        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value < 2 && value > 500)
                {
                    throw new ExceedingTheAllowedValue("Unacceptable weight");
                }
                weight = value;
            }
        }
    }
}
