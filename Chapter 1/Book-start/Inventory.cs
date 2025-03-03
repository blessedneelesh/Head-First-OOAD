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

        public void AddBook(BookSpec bookSpec, string author,  string publisher, int yearOfPublication, string isbn, double price)
        {
            Book book = new Book(bookSpec, author, publisher, yearOfPublication, isbn, price);
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

        public List<Book> Search(BookSpec searchSpec)
        {
            List<Book> matchingBooks = new List<Book>();
            for(int i = 0; i < books.Count(); i++)
            {
                Book book=books[i];
                BookSpec bookSpec = book.GetSpec();

                if (bookSpec.CompareBookSpec(searchSpec))
                {
                    matchingBooks.Add(book);
                }        
            }
            return matchingBooks;              
        }
    }
}
