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
        private Genre genre;
        private Language language;
        private Format format;
        private string publisher;
        private int yearOfPublication;
        private string isbn;
        private double price;

        public Book(string title, string author, Genre genre, Language language, Format format, string publisher, int yearOfPublication, string isbn, double price)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.language=language;
            this.format = format;
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

        public Genre GetGenre()
        {
            return genre;
        }

        public Language GetLanguage()
        {
            return language;
        }

        public Format GetFormat()
        {
            return format;
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
