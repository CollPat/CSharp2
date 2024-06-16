namespace BooksWrapUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookDatabase myBookDatabase = new BookDatabase();

            // Add books - is there a way to make it in simplier way than to add book after book? 
            myBookDatabase.AddBook(new Book("Get a Life, Chloe Brown", "Talia Hibbert", 248, 3, 4));
            myBookDatabase.AddBook(new Book("Time Shelter", "Georgi Gospodinov", 304, 3, 4));
            myBookDatabase.AddBook(new Book("DallerGut Dream Department Store", "Lee Mi-ye", 243, 3, 5));
            myBookDatabase.AddBook(new Book("XOXO", "Axie Oh", 352, 3, 2));
            myBookDatabase.AddBook(new Book("Bringing Down the Duke", "Evie Dunmore", 335, 2, 2));
            myBookDatabase.AddBook(new Book("The Bromance Book Club", "Lyssa Kay Adams", 352, 4, 3));
            myBookDatabase.AddBook(new Book("Beyond The Story", "Myeongseok Kang", 544, 15, 5));
            myBookDatabase.AddBook(new Book("10 Things That Never Happened", "Alexis Hall", 391, 8, 4));
            myBookDatabase.AddBook(new Book("Bride", "Ali Hazelwood", 416, 3, 2));
            myBookDatabase.AddBook(new Book("Beyond the Wand", "Tom Felton", 302, 4, 5));
            myBookDatabase.AddBook(new Book("Spoločenstvo prsteňa", "J.R.R. Tolkien", 456, 8, 5));
            myBookDatabase.AddBook(new Book("Hobit", "J.R.R. Tolkien", 232, 3, 5));
            myBookDatabase.AddBook(new Book("Atomic Habits", "James Clear", 320, 2, 4));
            myBookDatabase.AddBook(new Book("A Witch in Time", "Constance Sayers", 448, 13, 4));
            myBookDatabase.AddBook(new Book("Delayed Rays Of A Star", "Amanda Lee Koe", 383, 3, 3));
            myBookDatabase.AddBook(new Book("A Touch of Darkness", "Scarlett St. Clair", 400, 4, 1));
            myBookDatabase.AddBook(new Book("An Encore of Roses", "S.T. Gibson", 14, 1, 3));
            myBookDatabase.AddBook(new Book("A Dowry of Blood", "S.T. Gibson", 248, 2, 3));
            myBookDatabase.AddBook(new Book("The Invisible Life of Addie LaRue", "Victoria Schwab", 541, 10, 3));
            myBookDatabase.AddBook(new Book("Saha", "Cho Nam-Joo", 228, 3, 4));
            myBookDatabase.AddBook(new Book("The Reader", "Bernhard Schlink", 216, 2, 3));
            myBookDatabase.AddBook(new Book("Less", "Andrew Sean Greer", 272, 3, 4));
            myBookDatabase.AddBook(new Book("Things Remembered and Things Forgotten", "Kyōko Nakajima", 265, 4, 3));
            myBookDatabase.AddBook(new Book("Anna", "Niccolò Ammaniti", 296, 3, 3));
            myBookDatabase.AddBook(new Book("Kindred", "Octavia E. Butler", 295, 3, 4));
            myBookDatabase.AddBook(new Book("I Who Have Never Known Men", "Jacqueline Harpman", 208, 3, 3));
            myBookDatabase.AddBook(new Book("Spin", "Robert Charles Wilson", 376, 10, 2));
            myBookDatabase.AddBook(new Book("84K", "Claire North", 480, 8, 2));
            myBookDatabase.AddBook(new Book("My Sister, the Serial Killer", "Oyinkan Braithwaite", 226, 1, 4));
            myBookDatabase.AddBook(new Book("Piranesi", "Susanna Clarke", 245, 2, 4));
            myBookDatabase.AddBook(new Book("Dark Matter", "Blake Crouch", 398, 7, 3));
            myBookDatabase.AddBook(new Book("Welcome to the Hyunam-dong Bookshop", "Hwang Bo-Reum", 307, 5, 3));
            myBookDatabase.AddBook(new Book("Ocean's Echo", "Everina Maxwell", 464, 3, 4));
            myBookDatabase.AddBook(new Book("Thinking Fast and Slow", "Daniel Kahneman", 499, 20, 3));
            //Number of books that were read
            myBookDatabase.PrintTotalBooksReadWithDate();

            Console.ReadLine();
            //Number of Pages that were read overall
            int totalPagesRead = myBookDatabase.CountTotalPagesRead();
            Console.WriteLine($"Total pages that you have read are: {totalPagesRead}");
            Console.ReadLine() ;
            // Writes average pages read per day
            myBookDatabase.WriteAveragePagesReadPerDay();

            Console.ReadLine ();

            //how many books were read in a week on average 
            myBookDatabase.WriteAverageBooksReadPerWeek();

            Console.ReadLine();
            // List all books
            Console.WriteLine("This is list of all the books you have read in year 2024: ");
            Console.ReadLine();
            myBookDatabase.ListBooks();


            Console.ReadLine();

            // Find a book by name
            Console.Write("Cannot find a book in the list? Try to search for it: ");
            string partialName = Console.ReadLine();
            List<Book> foundBooks = myBookDatabase.FindBooksByPartialName(partialName);
            if (foundBooks.Count > 0)
            {
                Console.WriteLine("You have read these books:");
                foreach (var book in foundBooks)
                {
                    Console.WriteLine(book);
                }
            }
            else
            {
                Console.WriteLine("You have not read that book, yet.");
            }


            Console.ReadLine();

            //list of lowest rated and highest rated books
            myBookDatabase.ListLowestRatedBooks();
            Console.ReadLine();
            myBookDatabase.ListHighestRatedBooks();

            Console.ReadLine();

            //which book took the longest to read and which one was read the fastest
            myBookDatabase.ListFastestAndSlowestReadBooks();

            Console.ReadLine();

            // List shortest and longest books
            myBookDatabase.ListShortestAndLongestBooks();

        }
    }
}
