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
            BookSpec whatUserLikes = new BookSpec(Format.PAPERBACK, Genre.FICTION, Language.ENGLISH, "To Kill a Mockingbird");
            List<Book> book = inventory.Search(whatUserLikes);

          
            if (book.Count()>0)
            {
                for (int i = 0; i < book.Count(); i++)
                {
                    Console.WriteLine("You might like this book:\n" +
                                      "Title: " + book[i].GetSpec().GetTitle() + "\n" +
                                      "Author: " + book[i].GetAuthor() + "\n" +
                                      "Genre: " + book[i].GetSpec().GetGenre() + "\n" +
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
            inventory.AddBook(new BookSpec(Format.PAPERBACK, Genre.FICTION, Language.ENGLISH, "To Kill a Mockingbird"), "Harper Lee", "J.B. Lippincott & Co.", 1960, "9780446310789", 8.99);
            inventory.AddBook(new BookSpec(Format.PAPERBACK, Genre.FICTION, Language.ENGLISH, "To Kill a Mockingbird"), "Harper Lee", "J.B. Lippincott & Co.", 1960, "9780446310543", 11.99);

            // Add a non-fiction book
            inventory.AddBook(new BookSpec(Format.HARDCOVER, Genre.NON_FICTION, Language.ENGLISH, "Sapiens: A Brief History of Humankind"), "Yuval Noah Harari", "Harper", 2014, "9780062316097", 19.99);

            // Add a fantasy book
            inventory.AddBook(new BookSpec(Format.PAPERBACK, Genre.FANTASY, Language.ENGLISH, "The Hobbit"), "J.R.R. Tolkien", "Allen & Unwin", 1937, "9780547928227", 12.99);

            // Add a mystery book
            inventory.AddBook(new BookSpec(Format.PAPERBACK, Genre.MYSTERY, Language.ENGLISH, "The Girl with the Dragon Tattoo"), "Stieg Larsson", "Norstedts Förlag", 2005, "9780307269751", 10.99);

            // Add a romance book
            inventory.AddBook(new BookSpec(Format.PAPERBACK, Genre.ROMANCE, Language.ENGLISH, "Pride and Prejudice"), "Jane Austen", "T. Egerton, Whitehall", 1813, "9780141439518", 7.99);

            // Add a science fiction book
            inventory.AddBook(new BookSpec(Format.HARDCOVER, Genre.SCIENCE_FICTION, Language.ENGLISH, "Dune"), "Frank Herbert", "Chilton Books", 1965, "9780441172719", 15.99);

            // Add a horror book
            inventory.AddBook(new BookSpec(Format.PAPERBACK, Genre.HORROR, Language.ENGLISH, "The Shining"), "Stephen King", "Doubleday", 1977, "9780385121675", 9.99);

            // Add a biography
            inventory.AddBook(new BookSpec(Format.HARDCOVER, Genre.BIOGRAPHY, Language.ENGLISH, "Steve Jobs"), "Walter Isaacson", "Simon & Schuster", 2011, "9781451648539", 21.99);

            // Add a history book
            inventory.AddBook(new BookSpec(Format.PAPERBACK, Genre.HISTORY, Language.ENGLISH, "Guns, Germs, and Steel"), "Jared Diamond", "W.W. Norton & Company", 1997, "9780393317558", 14.99);

            // Add a self-help book
            inventory.AddBook(new BookSpec(Format.PAPERBACK, Genre.SELF_HELP, Language.ENGLISH, "Atomic Habits"), "James Clear", "Avery", 2018, "9780735211292", 16.99);

            // Add a book in French
            inventory.AddBook(new BookSpec(Format.PAPERBACK, Genre.FICTION, Language.FRENCH, "L'Étranger"), "Albert Camus", "Gallimard", 1942, "9782070360024", 11.99);

            // Add a book in Japanese
            inventory.AddBook(new BookSpec(Format.PAPERBACK, Genre.FICTION, Language.JAPANESE, "Norwegian Wood"), "Haruki Murakami", "Kodansha", 1987, "9784062748681", 13.99);

            // Add a book in German
            inventory.AddBook(new BookSpec(Format.PAPERBACK, Genre.FICTION, Language.GERMAN, "Die Verwandlung"), "Franz Kafka", "Kurt Wolff Verlag", 1915, "9783518188066", 10.99);
            inventory.AddBook(new BookSpec(Format.AUDIOBOOK, Genre.FICTION, Language.ENGLISH, "Die Verwandlung"), "Franz Kafka", "Kurt Wolff Verlag", 1915, "9783518188066", 10.99);

            // Add a book in Chinese
            inventory.AddBook(new BookSpec(Format.PAPERBACK, Genre.FICTION, Language.CHINESE, "活着"), "余华", "作家出版社", 1993, "9787506365437", 12.99);

            // Add a book in Russian
            inventory.AddBook(new BookSpec(Format.PAPERBACK, Genre.FICTION, Language.RUSSIAN, "Преступление и наказание"), "Фёдор Достоевский", "Русский вестник", 1866, "9785170906694", 9.99);

            // Add a book in Italian
            inventory.AddBook(new BookSpec(Format.PAPERBACK, Genre.FICTION, Language.ITALIAN, "Il Nome della Rosa"), "Umberto Eco", "Bompiani", 1980, "9788845246156", 14.99);

        }
    }
}
