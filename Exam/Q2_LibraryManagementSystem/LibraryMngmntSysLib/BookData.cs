using System.Collections.Generic;

namespace LibraryMngmntSysLib
{
    // sample data for books and some methods
    public class BookData
    {
        //sample data
        static List<Book> books = new List<Book>()
        {
            new Book() { BookId = 1, Title= "Java", Category="Educational", Author = "Bob", Price=100 },
            new Book() { BookId = 2, Title= "C#", Category="Educational", Author = "Alice", Price=150 },
            new Book() { BookId = 3, Title= "Harry Potter", Category="Fantasy", Author = "Williams", Price=300 },
            new Book() { BookId = 4, Title= "APJ Abdul Kalam", Category="Biography", Author = "Max", Price=500 },
            new Book() { BookId = 5, Title= "Percy Jackson", Category="Fantasy", Author = "George", Price=250 }
        };

        // access list at frontend
        public List<Book> GetBooksData()
        {
            return books;
        }

        // add book
        public void AddBook(Book b)
        {
            books.Add(b);
        }

        // update book data
        public void UpdateBook(Book b)
        {
            Book prevBook = books.Find(x => x.BookId == b.BookId);

            if (prevBook != null)
            {
                prevBook.Title = b.Title;
                prevBook.Author = b.Author;
                prevBook.Category = b.Category;
                prevBook.Price = b.Price;
            }
        }

        // remove book
        public void RemoveBook(Book b)
        {
            books.Remove(b);
        }

        // method to display book details
        public string DisplayAll(List<Book> bookList)
        {
            string result = null;
            foreach (Book book in bookList)
            {
                result += "Book Id: " + book.BookId + " - Title: " + book.Title + " - Author: " + book.Author + " - Category: " + book.Category + " - Price: " + book.Price + "<br/>";
            }
            return result;
        }
    }
}
