using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1.Book_start
{
    public class Book
    {
        private string title;
        private string author;
        private string genre;
        private string publisher;
        private int yearOfPublication;
        private string isbn;
        private double price;

        public Book(string title, string author, string genre, string publisher, int yearOfPublication, string isbn, double price)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.publisher = publisher;
            this.yearOfPublication = yearOfPublication;
            this.isbn = isbn;
            this.price = price;
        }

        public string GetTitle()
        {
            return title;
        }

        public string GetAuthor()
        {
            return author;
        }

        public string GetGenre()
        {
            return genre;
        }

        public string GetPublisher()
        {
            return publisher;
        }

        public int GetYearOfPublication()
        {
            return yearOfPublication;
        }

        public string GetIsbn()
        {
            return isbn;
        }

        public double GetPrice()
        {
            return price;
        }

        public void SetPrice(double newPrice)
        {
            this.price = newPrice;
        }
    }
}
