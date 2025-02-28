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
            Book whatUserLikes = new Book("To Kill a Mockingbird", "Harper Lee", Genre.FICTION,Language.ENGLISH,Format.PAPERBACK, "J.B. Lippincott & Co.", 1960, "", 0);
            List<Book> book = inventory.Search(whatUserLikes);

          
            if (book.Count()>0)
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
            // Add a classic fiction book
            inventory.AddBook("To Kill a Mockingbird", "Harper Lee", Genre.FICTION, Language.ENGLISH, Format.PAPERBACK, "J.B. Lippincott & Co.", 1960, "9780446310789", 8.99);
            inventory.AddBook("To Kill a Mockingbird", "Harper Lee", Genre.FICTION, Language.ENGLISH, Format.PAPERBACK, "J.B. Lippincott & Co.", 1960, "9780446310543", 11.99);

            // Add a non-fiction book
            inventory.AddBook("Sapiens: A Brief History of Humankind", "Yuval Noah Harari", Genre.NON_FICTION, Language.ENGLISH, Format.HARDCOVER, "Harper", 2014, "9780062316097", 19.99);

            // Add a fantasy book
            inventory.AddBook("The Hobbit", "J.R.R. Tolkien", Genre.FANTASY, Language.ENGLISH, Format.PAPERBACK, "Allen & Unwin", 1937, "9780547928227", 12.99);

            // Add a mystery book
            inventory.AddBook("The Girl with the Dragon Tattoo", "Stieg Larsson", Genre.MYSTERY, Language.ENGLISH, Format.PAPERBACK, "Norstedts Förlag", 2005, "9780307269751", 10.99);

            // Add a romance book
            inventory.AddBook("Pride and Prejudice", "Jane Austen", Genre.ROMANCE, Language.ENGLISH, Format.PAPERBACK, "T. Egerton, Whitehall", 1813, "9780141439518", 7.99);

            // Add a science fiction book
            inventory.AddBook("Dune", "Frank Herbert", Genre.SCIENCE_FICTION, Language.ENGLISH, Format.HARDCOVER, "Chilton Books", 1965, "9780441172719", 15.99);

            // Add a horror book
            inventory.AddBook("The Shining", "Stephen King", Genre.HORROR, Language.ENGLISH, Format.PAPERBACK, "Doubleday", 1977, "9780385121675", 9.99);

            // Add a biography
            inventory.AddBook("Steve Jobs", "Walter Isaacson", Genre.BIOGRAPHY, Language.ENGLISH, Format.HARDCOVER, "Simon & Schuster", 2011, "9781451648539", 21.99);

            // Add a history book
            inventory.AddBook("Guns, Germs, and Steel", "Jared Diamond", Genre.HISTORY, Language.ENGLISH, Format.PAPERBACK, "W.W. Norton & Company", 1997, "9780393317558", 14.99);

            // Add a self-help book
            inventory.AddBook("Atomic Habits", "James Clear", Genre.SELF_HELP, Language.ENGLISH, Format.PAPERBACK, "Avery", 2018, "9780735211292", 16.99);

            // Add a book in French
            inventory.AddBook("L'Étranger", "Albert Camus", Genre.FICTION, Language.FRENCH, Format.PAPERBACK, "Gallimard", 1942, "9782070360024", 11.99);

            // Add a book in Japanese
            inventory.AddBook("Norwegian Wood", "Haruki Murakami", Genre.FICTION, Language.JAPANESE, Format.PAPERBACK, "Kodansha", 1987, "9784062748681", 13.99);

            // Add a book in German
            inventory.AddBook("Die Verwandlung", "Franz Kafka", Genre.FICTION, Language.GERMAN, Format.PAPERBACK, "Kurt Wolff Verlag", 1915, "9783518188066", 10.99);

            // Add a book in Chinese
            inventory.AddBook("活着", "余华", Genre.FICTION, Language.CHINESE, Format.PAPERBACK, "作家出版社", 1993, "9787506365437", 12.99);

            // Add a book in Russian
            inventory.AddBook("Преступление и наказание", "Фёдор Достоевский", Genre.FICTION, Language.RUSSIAN, Format.PAPERBACK, "Русский вестник", 1866, "9785170906694", 9.99);

            // Add a book in Italian
            inventory.AddBook("Il Nome della Rosa", "Umberto Eco", Genre.FICTION, Language.ITALIAN, Format.PAPERBACK, "Bompiani", 1980, "9788845246156", 14.99);
        }
    }
}
