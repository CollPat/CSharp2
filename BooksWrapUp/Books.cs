using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksWrapUp
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }
        public int NumberOfDaysRead { get; set; }
        public int Rating { get; set; }

        public Book(string name, string author, int numberOfPages, int numberOfDaysRead, int rating)
        {
            Name = name;
            Author = author;
            NumberOfPages = numberOfPages;
            NumberOfDaysRead = numberOfDaysRead;
            Rating = rating;
        }

        public override string ToString()
        {
            return $"{Name} by {Author}, {NumberOfPages} pages, read in {NumberOfDaysRead} days, rating: {Rating} stars ";
        }
    }

}
