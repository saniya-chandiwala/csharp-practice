namespace BooksLib
{
    public class BookDetails
    {
        static Book[] books;

        static BookDetails()
        {
            books = new Book[]
            {
                new Book() { BookId = 1, BookTitle = "Lemon", IsAvailable = true },
                new Book() { BookId = 2, BookTitle = "Lemonade", IsAvailable = false },
                new Book() { BookId = 3, BookTitle = "Giraffe", IsAvailable = true }
            };
        }

        public Book GetBook(int id)
        {
            foreach (Book book in books)
            {
                if (book.BookId == id && book.IsAvailable)
                {
                    book.IsAvailable = false;
                    return book;
                }
            }
            return null;
        }
    }
}
