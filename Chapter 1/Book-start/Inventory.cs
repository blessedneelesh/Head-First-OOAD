using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1.Book_start
{
    public class Inventory
    {
        private List<Book> books;

        public Inventory()
        {
            books = new List<Book>();
        }

        public void AddBook(string title, string author, string genre, string publisher, int yearOfPublication, string isbn, double price)
        {
            Book book = new Book(title, author, genre, publisher, yearOfPublication, isbn, price);
            books.Add(book);
        }

        public Book GetBook(string isbn)
        {
            foreach (Book book in books)
            {
                if (book.GetIsbn().Equals(isbn))
                {
                    return book;
                }
            }
            return null;
        }

        public Book Search(Book searchBook)
        {
            foreach (Book book in books)
            {
                if ((searchBook.GetTitle() == null || searchBook.GetTitle().Equals(book.GetTitle())) &&
                    (searchBook.GetAuthor() == null || searchBook.GetAuthor().Equals(book.GetAuthor())) &&
                    (searchBook.GetGenre() == null || searchBook.GetGenre().Equals(book.GetGenre())) &&
                    (searchBook.GetPublisher() == null || searchBook.GetPublisher().Equals(book.GetPublisher())) &&
                    (searchBook.GetYearOfPublication() == 0 || searchBook.GetYearOfPublication() == book.GetYearOfPublication()))
                {
                    return book;
                }
            }
            return null;
        }
    }
}
