using Domain;

namespace Application
{

    public class SortBookService : ISortBookService
    {

        public List<Book> OrderBooks(Dictionary<string, string>? parameters)
        {
            List<Book> books = new Book().BookList();

            if (parameters == null)
            {
                throw new Exception("Invalid ordenation");
            }

            if (parameters.ContainsKey(string.Empty) || parameters.ContainsValue(string.Empty))
            {
                books = new List<Book>();
                return books;
            }         


            if (parameters.ContainsKey("Title"))
            {
                if (parameters["Title"].ToLower() == "asc")
                {
                    books = books.OrderBy(b => b.Title).ToList();
                }
                else if (parameters["Title"].ToLower() == "desc")
                {
                    books = books.OrderByDescending(b => b.Title).ToList();
                }
            }

            if (parameters.ContainsKey("Author"))
            {
                if (parameters["Author"].ToLower() == "asc")
                {
                    books = books.OrderBy(b => b.Author).ToList();
                }
                else if (parameters["Author"].ToLower() == "desc")
                {
                    books = books.OrderByDescending(b => b.Author).ToList();
                }
            }

            if (parameters.ContainsKey("Edition"))
            {
                if (parameters["Edition"].ToLower() == "asc")
                {
                    books = books.OrderBy(b => b.Edition).ToList();
                }
                else if (parameters["Edition"].ToLower() == "desc")
                {
                    books = books.OrderByDescending(b => b.Edition).ToList();
                }
            }         

            return books;       
        
        }
    }
}

