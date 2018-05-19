using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.ITCompany
{
    public class Customer
    {
        private string name;

        public Customer(string name)
        {
            Name = name;
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
                    throw new ArgumentNullException("Name can't be null");
                }
                name = value;
            }
        }
        
    }
}
