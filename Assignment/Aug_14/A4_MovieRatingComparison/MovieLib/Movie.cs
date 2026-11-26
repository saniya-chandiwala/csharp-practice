namespace MovieLib
{
    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; }

        public Movie CompareRating(Movie m)
        {
            if (this.Rating > m.Rating)
                return this;

            if (m.Rating > this.Rating)
                return m;

            return null;
        }
    }
}
