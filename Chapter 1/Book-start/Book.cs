using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Chapter_1.Book_start
{
    public class Book
    {
        private BookSpec bookSpec;
        private string author;
        private string publisher;
        private int yearOfPublication;
        private string isbn;
        private double price;

        public Book(BookSpec bookSpec, string author, string publisher, int yearOfPublication, string isbn, double price)
        {
            this.bookSpec = bookSpec;
            this.author = author;
            this.publisher = publisher;
            this.yearOfPublication = yearOfPublication;
            this.isbn = isbn;
            this.price = price;
        }

        public BookSpec GetSpec()
        {
            return bookSpec;
        }

        public string GetAuthor()
        {
            return author;
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
