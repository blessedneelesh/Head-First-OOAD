using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1.Book_start
{
    public class FindBookTester
    {
        public static void main(string[] args)
        {
            // Set up the book inventory
            Inventory inventory = new Inventory();
            InitializeInventory(inventory);

            // Create a book that matches the user's preferences
            Book whatUserLikes = new Book("The Great Gatsby", "F. Scott Fitzgerald", "Fiction", "Scribner", 1925, "", 0);
            List<Book> book = inventory.Search(whatUserLikes);

          
            if (book.Count()>1)
            {
                for (int i = 0; i < book.Count(); i++)
                {
                    Console.WriteLine("You might like this book:\n" +
                                      "Title: " + book[i].GetTitle() + "\n" +
                                      "Author: " + book[i].GetAuthor() + "\n" +
                                      "Genre: " + book[i].GetGenre() + "\n" +
                                      "Publisher: " + book[i].GetPublisher() + "\n" +
                                      "Year of Publication: " + book[i].GetYearOfPublication() + "\n" +
                                      "Price: $" + book[i].GetPrice()+"\n -------------");
                }
            }else
                {
                    Console.WriteLine("Sorry, we have nothing for you.");
                }
        }

        private static void InitializeInventory(Inventory inventory)
        {
            inventory.AddBook("The Great Gatsby", "F. Scott Fitzgerald", "Fiction", "Scribner", 1925, "9780743273565", 11.99);
            //inventory.AddBook("The Great Gatsby", "F. Scott Fitzgerald", "Fiction", "Scribner", 1925, "9780743272345", 10.99);
            inventory.AddBook("To Kill a Mockingbird", "Harper Lee", "Fiction", "J.B. Lippincott & Co.", 1960, "9780446310789", 7.99);
            inventory.AddBook("1984", "George Orwell", "Sci-Fi", "Secker & Warburg", 1949, "9780451524935", 6.99);
            inventory.AddBook("The Catcher in the Rye", "J.D. Salinger", "Fiction", "Little, Brown and Company", 1951, "9780316769488", 8.99);
            inventory.AddBook("The Hobbit", "J.R.R. Tolkien", "Fantasy", "Allen & Unwin", 1937, "9780547928227", 12.99);
        }
    }
}
