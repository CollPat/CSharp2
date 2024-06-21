using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace BooksWrapUp
{
    using System.Collections.Generic;

    public class BookDatabase
    {
        private List<Book> books;
        private const string DataFilePath = "books.json";

        public BookDatabase()
        {
            books = new List<Book>();
            LoadBooksFromFile();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            SaveBooksToFile();
        }

        public void ListBooks()
        {
            Console.WriteLine("Here is the list of all books you have read:");
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
                    Console.WriteLine($"{book.Name} with rating {book.Rating} stars");
                }
            }
        }

        public void ListHighestRatedBooks()
        {
            var highestRatedBooks = books.FindAll(book => book.Rating == 4 || book.Rating == 5);
            if (highestRatedBooks.Count == 0)
            {
                Console.WriteLine("No books with 4 or 5 star ratings were found.");

            }
            else
            {
                Console.WriteLine("Highest rated books books that you have read are:");
                foreach (var book in highestRatedBooks)
                {
                    Console.WriteLine($"{book.Name} with rating {book.Rating} stars");
                }
            }
        }

        public void ChangeRating(string bookName, int newRating)
        {
            Book book = books.Find(b => b.Name.Equals(bookName, StringComparison.OrdinalIgnoreCase));
            if (book != null)
            {
                book.Rating = newRating;
                Console.WriteLine($"Rating for '{bookName}' has been changed to {newRating}.");
            }
            else
            {
                Console.WriteLine($"Book '{bookName}' not found.");
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

            Console.WriteLine($"The book you have read the fastest was: {fastestReadBook.Name} in {fastestReadBook.NumberOfDaysRead} day");
            Console.WriteLine($"The book you have read the slowest was: {slowestReadBook.Name} in {slowestReadBook.NumberOfDaysRead} days");
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

        public void WriteAveragePagesReadPerDay()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books in the database.");
                return;
            }

            int totalPagesRead = books.Sum(book => book.NumberOfPages);
            DateTime startOfYear = new DateTime(DateTime.Now.Year, 1, 1);
            int daysElapsed = (DateTime.Now - startOfYear).Days + 1;

            double averagePagesPerDay = (double)totalPagesRead / daysElapsed;
            Console.WriteLine($"Which means that average pages you read per day in {DateTime.Now.Year} are {averagePagesPerDay:F2}");
        }

        public void WriteAverageBooksReadPerWeek()
        {
             
            if (books.Count == 0)
            {
                Console.WriteLine("No books in the database.");
                return;
            }

            int totalBooksRead = books.Count;
            DateTime startOfYear = new DateTime(DateTime.Now.Year, 1, 1);
            int daysElapsed = (DateTime.Now - startOfYear).Days + 1;
            double weeksElapsed = daysElapsed / 7.0;

            double averageBooksPerWeek = totalBooksRead / weeksElapsed;
            Console.WriteLine($"And the average number of books you read per week in {DateTime.Now.Year} is {averageBooksPerWeek:F2}");
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

            Console.WriteLine($"Shortest book that you have read was: {shortestBook.Name} with {shortestBook.NumberOfPages} pages");
            Console.WriteLine($"Longest book that you have read was: {longestBook.Name} with {longestBook.NumberOfPages} pages");
        }

        private void SaveBooksToFile()
        {
            string json = JsonSerializer.Serialize(books, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(DataFilePath, json);
        }

        private void LoadBooksFromFile()
        {
            if (File.Exists(DataFilePath))
            {
                string json = File.ReadAllText(DataFilePath);
                books = JsonSerializer.Deserialize<List<Book>>(json) ?? new List<Book>();
            }

        }
    }
}

