using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Book
    {
        private string title;
        private int numberOfPages;
        private string publishingHouse;
        private int yearOfPublishing;
        private int yearOfWriting;
        private Author author;
        public Book(string title, int numberOfPages, string publishingHouse, int yearOfPublishing, int yearOfWriting, Author author)
        {
            Title = title;
            NumberOfPages = numberOfPages;
            PublishingHouse = publishingHouse;
            YearOfWriting = yearOfWriting;
            YearOfPublishing = yearOfPublishing;
            Author = author;            
        }
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentNullException("Title of the book can't be null");
                }
                title = value;
            }
        }
        public int NumberOfPages
        {
            get
            {
                return numberOfPages;
            }
            set
            {
                if (value < 0)
                {
                    throw new ExceedingTheAllowedValue("The number of pages can't be less than zero");
                }
                numberOfPages = value;
            }
        }
        public string PublishingHouse
        {
            get
            {
                return publishingHouse;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentNullException("Publishing house can't be null");
                }
                publishingHouse = value;                                   
            }
        }
        public int YearOfWriting
        {
            get
            {
                return yearOfWriting;
            }
            set
            {
                if (value < 0)
                {
                    throw new ExceedingTheAllowedValue("The year of writing can't be less than zero");
                }
                yearOfWriting = value;                    
            }
        }
        public int YearOfPublishing
        {
            get
            {
                return yearOfPublishing;
            }
            set
            {
                if (yearOfWriting < value)
                {
                    throw new ExceedingTheAllowedValue("The year of publishing can't be less than year of writing");
                }
                yearOfPublishing = value;  
            }
        }
        public Author Author
        {
            get
            {
                return author;
            }
            set
            {
                if (value != null)
                {
                    throw new System.ArgumentNullException("Author can't be null");
                }
                author = value;
            }
        }
    }
}
