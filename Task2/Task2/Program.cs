using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 1:
                    {
                        try
                        {
                            #region dump
                            //string name;
                            //int age;
                            //int growth;
                            //int weight;
                            //Console.Write("Enter name:");
                            //name = Console.ReadLine();
                            //Console.Write("Enter age:");
                            //age = int.Parse(Console.ReadLine()); ;
                            //Console.Write("Enter growth:");
                            //growth = int.Parse(Console.ReadLine()); ;
                            //Console.Write("Enter weight:");
                            //weight = int.Parse(Console.ReadLine());
                            #endregion

                            StreamReader inp = new StreamReader("input1.txt");

                            string name = inp.ReadLine();
                            int age = int.Parse(inp.ReadLine());
                            int growth = int.Parse(inp.ReadLine());
                            int weight = int.Parse(inp.ReadLine());

                            inp.Close();

                            Man man = new Man(name, age, growth, weight);
                        }
                        catch (ArgumentNullException NullEx)
                        {
                            Console.WriteLine(NullEx.Message);
                        }
                        catch (ExceedingTheAllowedValue ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (System.FormatException Ex)
                        {
                            Console.WriteLine(Ex.Message);
                        }
                        break;
                    }
                case 2:
                    {
                        try
                        {
                            #region dump
                            //string name;
                            //int age;
                            //int growth;
                            //int weight;
                            //int yearOfBegin;
                            //int course;
                            //int group;
                            //Console.Write("Enter name:");
                            //name = Console.ReadLine();
                            //Console.Write("Enter age:");
                            //age = int.Parse(Console.ReadLine()); ;
                            //Console.Write("Enter growth:");
                            //growth = int.Parse(Console.ReadLine()); ;
                            //Console.Write("Enter weight:");
                            //weight = int.Parse(Console.ReadLine());
                            //Console.Write("Enter year of the beginning study:");
                            //yearOfBegin = int.Parse(Console.ReadLine());
                            //Console.Write("Enter course:");
                            //course = int.Parse(Console.ReadLine());
                            //Console.Write("Enter group number:");
                            //group = int.Parse(Console.ReadLine());
                            #endregion

                            StreamReader inp = new StreamReader("input2.txt");

                            string name = inp.ReadLine();
                            int age = int.Parse(inp.ReadLine());
                            int growth = int.Parse(inp.ReadLine());
                            int weight = int.Parse(inp.ReadLine());
                            int yearOfBegin = int.Parse(inp.ReadLine());
                            int course = int.Parse(inp.ReadLine());
                            int group = int.Parse(inp.ReadLine());

                            inp.Close();
                            
                            Student student = new Student(name, age, growth, weight, yearOfBegin, course, group);                           
                        }
                        catch (ArgumentNullException NullEx)
                        {
                            Console.WriteLine(NullEx.Message);
                        }
                        catch (ExceedingTheAllowedValue ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (System.FormatException Ex)
                        {
                            Console.WriteLine(Ex.Message);
                        }
                        break;
                    }
                case 3:
                    {
                        try
                        {
                            #region dump
                            //Console.Write("Enter name:");
                            //string name = Console.ReadLine();
                            //Console.Write("Enter surname:");
                            //string surname = Console.ReadLine();
                            //Console.Write("Enter year of author birth:");
                            //int yearOfBirth = int.Parse(Console.ReadLine());
                            //Console.Write("Enter title of the book:");
                            //string title = Console.ReadLine();
                            //Console.Write("Enter growth:");
                            //int numberOfPages = int.Parse(Console.ReadLine()); ;
                            //Console.Write("Enter weight:");
                            //string publishingHouse = Console.ReadLine();
                            //Console.Write("Enter year of author birth:");
                            //int yearOfPublishing = int.Parse(Console.ReadLine());
                            //Console.Write("Enter year of author birth:");
                            //int yearOfWriting = int.Parse(Console.ReadLine());
                            #endregion

                            StreamReader inp = new StreamReader("input3.txt");

                            string name = inp.ReadLine();
                            string surname = inp.ReadLine();
                            int yearOfBirth = int.Parse(inp.ReadLine());
                            string title = inp.ReadLine();
                            int numberOfPages = int.Parse(inp.ReadLine());
                            string publishingHouse = inp.ReadLine();
                            int yearOfPublishing = int.Parse(inp.ReadLine());
                            int yearOfWriting = int.Parse(inp.ReadLine());

                            inp.Close();

                            Book book = new Book(title, numberOfPages, publishingHouse, yearOfPublishing, yearOfWriting, new Author(name, surname, yearOfBirth));
                        }
                        catch (ArgumentNullException NullEx)
                        {
                            Console.WriteLine(NullEx.Message);
                        }
                        catch (ExceedingTheAllowedValue ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (System.FormatException Ex)
                        {
                            Console.WriteLine(Ex.Message);
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Wrong number");
                        break;
                    }
            }
        }
    }
}
