using System;
using System.Collections.Generic;
using Task3.ITCompany.Bugs;

namespace Task3.ITCompany.TypeOfCode
{
    public abstract class Code
    {
        private List<Bug> bugs;
        public int RowCount
        {
            get => RowCount;           
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Too few lines");
                }
                RowCount = value;
            }
        }
        public void CorrectBugs()
        {
            if (!IsOkay())
            {
                for (int i = 0; i < bugs.Count; i++)
                {
                    if (bugs[i].DoesExists)
                    {
                        RowCount += 10;
                        bugs[i].DoesExists = false;
                    }
                }
            }

            Console.WriteLine("All bugs have been fixed");
        }
        public bool IsOkay()
        {
            foreach (Bug item in bugs)
            {
                if (item.DoesExists)
                {
                    return false;
                }
            }
            return true;
        }
        
    }
}
