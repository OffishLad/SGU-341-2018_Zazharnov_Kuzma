using System;
using System.Collections.Generic;
using Task3.TransportCompany;
using Task3.TransportCompany.RealTransport;
using Task3.ITCompany;
using Task3.ITCompany.Workers;
using Task3.ITCompany.TypeOfCode;


namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Transport
            Cargo cargo = new Cargo()
            {
                Name = "Sheets",
                Weight = 5,
            };
            Order order = new Order(cargo, "SSU");
            var car = new Car()
            {
                Speed = 90,
                PersonnelCount = 1,
                PassengersCount = 3,
            };

            var delivery = new Delivery(car, order);
            delivery.Complete();
            #endregion

            #region ITcompany
            Customer customer = new Customer("John");

            List<Programmer> programmers = new List<Programmer>();
            programmers.Add(new BackendProgrammer());
            programmers.Add(new FrontendProgrammer());

            List<Tester> testers = new List<Tester>();
            testers.Add(new ManualTester());
            testers.Add(new AutoTester());

            List<Code> code = new List<Code>();
            code.Add(new BackendCode());
            code.Add(new FrontendCode());

            Project project = new Project(programmers, testers, code, "Example", customer);
            #endregion

        }
    }
}
