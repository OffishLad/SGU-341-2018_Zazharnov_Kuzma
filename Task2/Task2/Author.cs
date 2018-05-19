using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Author
    {
        private string name;
        private string surname;
        private int yearOfBirth;

        public Author(string name, string surname, int yearOfBirth)
        {
            Name = name;
            Surname = surname;
            YearOfBirth = yearOfBirth;
        }
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
                    throw new System.ArgumentNullException("Author name can't be null");
                }
                name = value;                
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentNullException("Author surname can't be null");
                }
                surname = value;
            }
        }
        public int YearOfBirth
        {
            get
            {
                return yearOfBirth;
            }
            set
            {
                if (value < 0)
                {
                    throw new ExceedingTheAllowedValue("The year of author birth can't be less than zero");
                }
                yearOfBirth = value;
            }
        }
    }
}
