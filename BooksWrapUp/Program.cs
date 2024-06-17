namespace BooksWrapUp
{
    internal class Program
    {
        private static void ChangeBookRatingOption(BookDatabase myBookDatabase)
        {
            while (true)
            {
                Console.Write("Do you want to change the rating of any book? (yes/no): ");
                string response = Console.ReadLine();
                if (response.ToLower() == "no") break;

                if (response.ToLower() == "yes")
                {
                    Console.Write("Enter the name of the book to change the rating: ");
                    string bookName = Console.ReadLine();
                    Console.Write("Enter the new rating (1-5): ");
                    int newRating = int.Parse(Console.ReadLine());

                    myBookDatabase.ChangeRating(bookName, newRating);
                }
                else
                {
                    Console.WriteLine("Invalid response. Please enter 'yes' or 'no'.");
                }
            }
        }
        private static void InteractiveBookSearch(BookDatabase myBookDatabase)

        {
            while (true)
            {
                Console.Write("Enter part of the book name to search (or press 'x' to quit): ");
                string partialName = Console.ReadLine();
                if (partialName.ToLower() == "x") break;

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
                    Console.WriteLine("Unfortunately, you have not read any books with that name.");
                    Console.WriteLine("However! You can press:");
                    Console.WriteLine("1. To add the book with details.");
                    Console.WriteLine("2. Or, continue with book wrap up.");
                    string choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        Console.Write("Enter the book name: ");
                        string bookName = Console.ReadLine();
                        Console.Write("Enter the author: ");
                        string author = Console.ReadLine();
                        Console.Write("Enter the number of pages: ");
                        int numberOfPages = int.Parse(Console.ReadLine());
                        Console.Write("Enter the number of days you read it: ");
                        int numberOfDays = int.Parse(Console.ReadLine());
                        Console.Write("Enter your rating (1-5): ");
                        int rating = int.Parse(Console.ReadLine());

                        myBookDatabase.AddBook(new Book(bookName, author, numberOfPages, numberOfDays, rating));
                        Console.WriteLine("Book added successfully!");
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("You have not added any books.");
                    }
                }
            }
        }
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
            myBookDatabase.AddBook(new Book("Guardian", "Priest", 412, 2, 5));


            // Interactive menu
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("0. View all books I have read");
                Console.WriteLine("1. Search for a book and add a book");
                Console.WriteLine("2. List lowest rated books");
                Console.WriteLine("3. List highest rated books");
                Console.WriteLine("4. List the books I have read the fastest and the slowest");
                Console.WriteLine("5. Show me total books read up to this day");
                Console.WriteLine("6. Count total pages read of all the books");
                Console.WriteLine("7. List shortest and longest books in my list");
                Console.WriteLine("8. Show average pages I have read per day");
                Console.WriteLine("9. Show average books read per week");
                Console.WriteLine("X. Exit");
                Console.Write("I choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        myBookDatabase.ListBooks();
                        break;
                    case "1":
                        InteractiveBookSearch(myBookDatabase);
                        break;
                    case "2":
                        myBookDatabase.ListLowestRatedBooks();
                        ChangeBookRatingOption(myBookDatabase);
                        break;

                    case "3":
                        myBookDatabase.ListHighestRatedBooks();
                        ChangeBookRatingOption(myBookDatabase);
                        break;
                    case "4":
                        myBookDatabase.ListFastestAndSlowestReadBooks();
                        break;
                    case "5":
                        myBookDatabase.PrintTotalBooksReadWithDate();
                        break;
                    case "6":
                        int totalPagesRead = myBookDatabase.CountTotalPagesRead();
                        Console.WriteLine($"Total pages read: {totalPagesRead}");
                        break;
                    case "7":
                        myBookDatabase.ListShortestAndLongestBooks();
                        break;
                    case "8":
                        myBookDatabase.WriteAveragePagesReadPerDay();
                        break;
                    case "9":
                        myBookDatabase.WriteAverageBooksReadPerWeek();
                        break;
                    case "X":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}

