using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Student : Man
    {
        private int yearOfBegin;
        private int course;
        private int groupNumber;
                
        public Student(string name, int age, int growth, int weight, int year, int course, int groupNumber) :
            base(name, age, growth, weight)
        {
            YearOfBegin = year;
            Course = course;
            GroupNumber = groupNumber;
        }
        public int YearOfBegin
        {
            get
            {
                return yearOfBegin;
            }
            set
            {
                if (value < 1755 && value > DateTime.Now.Year) //Год поступления не может быть больше текущего
                {
                    throw new ExceedingTheAllowedValue("Unacceptable year");
                }
                yearOfBegin = value;
            }
        }

        public int Course
        {
            get
            {
                return course;
            }
            set
            {
                if (value < 0 && value > 6)
                {
                    throw new ExceedingTheAllowedValue("Unacceptable course");
                }
                course = value;                
            }
        }
        public int GroupNumber
        {
            get
            {
                return groupNumber;
            }
            set
            {
                if (value < 99 && value > 1000)
                {
                    throw new ExceedingTheAllowedValue("Unacceptable group number");
                }
                groupNumber = value;
            }
        }
    }
}
