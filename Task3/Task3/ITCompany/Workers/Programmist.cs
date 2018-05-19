using System;

namespace Task3.ITCompany.Workers
{
    public abstract class Programmist
    {
        private string name;
        private int skill;

        protected Programmist()
        { }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can't be null");
                }
                name = value;
            }
        }
        public int Skill
        {
            get
            {
                return skill;
            }
            set
            {
                if (value > 4 || value < 1)
                {
                    throw new Exception("Skill must be between 1 and 4");
                }
                skill = value;
            }
        }
        public void TimeToPaid()
        {
            Console.WriteLine("Programmer ended his part of work and want some money");
        }
    }
}
