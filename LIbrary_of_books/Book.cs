namespace LIbrary_of_books
{
    public class Book
    {
        static private int NextId = 1;
        public int Id { get; private set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public bool Discount { get; set; }
        public Book(string title, string author, string genre, bool discount)
        {
            Id = NextId++;
            Title = title;
            Author = author;
            Genre = genre;
            Discount = discount;
        }
    }
}
