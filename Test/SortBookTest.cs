using Application;

public class BookServiceTests
{
    private readonly ISortBookService _bookService;

    public BookServiceTests()
    {
        _bookService = new SortBookService();
    }

    [Fact]
    public void OrderBooks_TitleAsc()
    {        
        var sorting = new Dictionary<string, string>()
        {           
            {"Title", "asc"}           
        };
                
        var result = _bookService.OrderBooks(sorting);

        //expected order
        Assert.Equal("Head First Design Patterns", result[0].Title);
        Assert.Equal("Internet & World Wide Web: How to Program", result[1].Title);
        Assert.Equal("Java How to Program", result[2].Title);
        Assert.Equal("Patterns of Enterprise Application Architecture", result[3].Title);
    }

    [Fact]
    public void OrderBooks_AuthorAscAndTitleDesc()
    {       
        var sorting = new Dictionary<string, string>()
        {            
            {"Author", "asc"},
            {"Title","desc" }

        };
        
        var result = _bookService.OrderBooks(sorting);


        Assert.Equal("Java How to Program", result[0].Title);
        Assert.Equal("Internet & World Wide Web: How to Program", result[1].Title);
        Assert.Equal("Head First Design Patterns", result[2].Title);
        Assert.Equal("Patterns of Enterprise Application Architecture", result[3].Title);  
    }

    [Fact]
    public void OrderBooks_EditionDescAndAuthorDescAndTitleAsc()
    {
        
        var sorting = new Dictionary<string, string>()
        {
            {"Edition", "desc"},
            {"Author", "desc"},
            {"Title","asc" }
        };
      
        var result = _bookService.OrderBooks(sorting);
       
        Assert.Equal("Internet & World Wide Web: How to Program", result[0].Title);
        Assert.Equal("Java How to Program", result[1].Title);
        Assert.Equal("Head First Design Patterns", result[2].Title);        
        Assert.Equal("Patterns of Enterprise Application Architecture", result[3].Title);

    }

    [Fact]
    public void OrderBooks_Empty()
    {
        var sorting = new Dictionary<string, string>()
        {
            {"", ""}
        };

        var result = _bookService.OrderBooks(sorting);
        
        Assert.Empty(result);
        
    }

    [Fact]
    public void OrderBooks_Null()
    {
        Dictionary<string, string>? sorting = null;
       
        Action action = () => _bookService.OrderBooks(sorting);

        Assert.Throws<Exception>(action);

    }
}