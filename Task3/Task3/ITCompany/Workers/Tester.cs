using System;

namespace Task3.ITCompany.Workers
{
    public abstract class Tester : Programmist
    {
        public void FindBugs()
        {
            Console.WriteLine("I find some bugs");
        }
    }
}
