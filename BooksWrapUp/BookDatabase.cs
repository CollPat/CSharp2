using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksWrapUp
{
    using System.Collections.Generic;

    public class BookDatabase
    {
        private List<Book> books;

        public BookDatabase()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void ListBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }

        public List<Book> FindBooksByPartialName(string partialName)
        {
            return books.FindAll(book => book.Name.IndexOf(partialName, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public void ListLowestRatedBooks()
        {
            var lowestRatedBooks = books.FindAll(book => book.Rating == 1 || book.Rating == 2);
            if (lowestRatedBooks.Count == 0)
            {
                Console.WriteLine("No books with 1 or 2 star ratings.");
            }
            else
            {
                Console.WriteLine("Lowest rated books that you have read are:");
                foreach (var book in lowestRatedBooks)
                {
                    Console.WriteLine(book.Name);
                }
            }
        }

        public void ListHighestRatedBooks() 
        {
            var highestRatedBooks = books.FindAll(book => book.Rating == 4  || book.Rating == 5);
            if (highestRatedBooks.Count == 0)
            {
                Console.WriteLine("No books with 4 or 5 star ratings were found.");

            }
            else
            {
                Console.WriteLine("Highest rated books books that you have read are:");
                foreach (var book in highestRatedBooks)
                {
                    Console.WriteLine(book.Name);
                }
            }
        }

        public void ListFastestAndSlowestReadBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books in the database.");
                return;
            }

            Book fastestReadBook = books.OrderBy(book => book.NumberOfDaysRead).FirstOrDefault();
            Book slowestReadBook = books.OrderByDescending(book => book.NumberOfDaysRead).FirstOrDefault();

            Console.WriteLine($"The book you have read the fastest was: {fastestReadBook}");
            Console.WriteLine($"The book you have read the slowest was: {slowestReadBook}");
        }

        public int CountBooksRead()
        {
            return books.Count;
        }

        public void PrintTotalBooksReadWithDate()
        {
            int totalBooksRead = CountBooksRead();
            string currentDate = DateTime.Now.ToString("dd. MM. yyyy");
            Console.WriteLine($"By the day, {currentDate}, you have read {totalBooksRead} books in year 2024.");
        }

        public int CountTotalPagesRead()
        {

            return books.Sum(book => book.NumberOfPages);
        }

        public void ListShortestAndLongestBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books in the database.");
                return;
            }

            Book shortestBook = books.OrderBy(book => book.NumberOfPages).FirstOrDefault();
            Book longestBook = books.OrderByDescending(book => book.NumberOfPages).FirstOrDefault();

            Console.WriteLine($"Shortest book that you have read was: {shortestBook}");
            Console.WriteLine($"Longest book that you have read was: {longestBook}");
        }



    }

}

