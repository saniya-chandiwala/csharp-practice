namespace BookLibraryLib
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Book( int id, string name, double price)
        {
            BookId = id;
            Name = name;
            Price = price;
        }
    }
}
