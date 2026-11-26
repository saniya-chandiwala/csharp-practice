using System;

namespace LibraryMngmntSysLib
{
    // book properties and comparable method for sorting books
    public class Book : IComparable<Book>
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }

        public int CompareTo(Book other)
        {
            return Title.CompareTo(other.Title);
        }
    }
}
