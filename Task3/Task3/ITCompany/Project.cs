using System;
using System.Collections.Generic;
using Task3.ITCompany.TypeOfCode;
using Task3.ITCompany.Workers;

namespace Task3.ITCompany
{
    public class Project
    {
        private List<Programmer> programmers;
        private List<Tester> testers;
        private List<Code> code;
        private string title;
        private Customer customer;
        public Project()
        {

        }
        public Project(List<Programmer> programmer, List<Tester> testers, List<Code> code, 
            string title, Customer customer)
        {
            Programmers = programmer;
            Testers = testers;
            Code = code;
            Title = title;
            Customer = customer;
        }
        public List<Programmer> Programmers
        {
            get
            {
                return programmers;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("List of programmers can't be null");
                }
                programmers = value;
            }
        }
        public List<Tester> Testers
        {
            get
            {
                return testers;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("List of testers can't be null");
                }
                testers = value;
            }
        }
        public List<Code> Code
        {
            get
            {
                return code;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("List of code can't be null");
                }
                code = value;
            }
        }
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Title can't be null");
                }
                title = value;
            }
        }
        public Customer Customer
        {
            get
            {
                return customer;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Customer can't be null");
                }
                customer = value;
            }
        }
    }
}
