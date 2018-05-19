using System;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader input = new StreamReader("input.txt");
                string[] temp = input.ReadToEnd().Split(' ', '\n');
                Triangle example = new Triangle(double.Parse(temp[0]), double.Parse(temp[1]),
                                                  double.Parse(temp[2]), double.Parse(temp[3]),
                                                  double.Parse(temp[4]), double.Parse(temp[5]));
                Console.WriteLine(example.Peremeter());
                Console.WriteLine(example.Area());

                //example.FirstPoint = new Point(3, 0);
                Triangle secondEx = new Triangle(new Point(0, 0), /*new Point(3, 5)*/ null, new Point(7, 10));
                //return;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
