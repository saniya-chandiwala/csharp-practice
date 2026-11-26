namespace BookLibraryLib
{
    public class BookLibrary
    {
        static Book b1 = new Book(101, "C#", 200);
        static Book b2 = new Book(102, "Java", 300);
        static Book b3 = new Book(103, "Python", 400);

        public Book SearchBook(int id)
        {
            switch (id)
            {
                case 101:
                    return b1;

                case 102:
                    return b2;

                case 103:
                    return b3;

                default:
                    return null;
            }
        }
    }
}
