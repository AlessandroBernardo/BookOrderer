namespace Domain
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public int Edition { get; set; }

        public List<Book> BookList()
        {
            List<Book> Books = new List<Book>();

            Books.Add(new Book
            {
                Id = 1,
                Title = "Java How to Program",
                Author = "Deitel & Deitel",
                Edition = 2007
            });

            Books.Add(new Book
            {
                Id = 2,
                Title = "Patterns of Enterprise Application Architecture",
                Author = "Martin Fowler",
                Edition = 2002
            });

            Books.Add(new Book
            {
                Id = 3,
                Title = "Head First Design Patterns",
                Author = "Elisabeth Freeman",
                Edition = 2004
            });

            Books.Add(new Book
            {
                Id = 4,
                Title = "Internet & World Wide Web: How to Program",
                Author = "Deitel & Deitel",
                Edition = 2007
            });

            return Books;
        }
    }

    
}
