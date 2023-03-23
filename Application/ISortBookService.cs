using Domain;

namespace Application
{
    public interface ISortBookService
    {
       List<Book> OrderBooks(Dictionary<string, string>? parameters);

    }
}
