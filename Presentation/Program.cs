// See https://aka.ms/new-console-template for more information
using Application;
using Domain;
using Microsoft.Extensions.Configuration;

internal class Program
{
    private static void Main(string[] args)
    {
        var _bookService = new SortBookService();

        IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
              .Build();

        var booksSection = config.GetSection("Books").Get<Book[]>();
        var sorting = config.GetSection("Sorting").Get<SortingOption[]>();

        Console.WriteLine("Coleção de livros");

        foreach (var book in booksSection)
        {
            Console.WriteLine($"{book.Id} {book.Title} - Author: {book.Author} - Edition: {book.Edition}");
        }

        Console.WriteLine();

        while (true)
        {
            Console.WriteLine("Digite o número da respectiva ordenação que deseja e aperte enter.");
            var index = 1;
            foreach (var item in sorting)
            {
                Console.WriteLine($" {index++} - {item.Texto}");
            }

            Console.WriteLine();
            var option = Console.ReadLine();


            var param = new Dictionary<string, string>();

            switch (option)
            {
                case "1":
                    param = new Dictionary<string, string>()
                    {
                        {"Title", "asc" }
                    };
                    break;

                case "2":
                    param = new Dictionary<string, string>()
                    {
                        { "Author", "asc" },
                        { "Title", "desc" }
                    };
                    break;

                case "3":
                    param = new Dictionary<string, string>()
                    {
                        {"Edition", "desc" },
                        { "Author", "desc" },
                        { "Title", "asc"  }
                    };
                    break;

                default:
                    Console.WriteLine("Valor inválido");
                    break;
            }

            var result = _bookService.OrderBooks(param);

            //resultado
            Console.WriteLine($"Resultado ordenado por {sorting[int.Parse(option)-1].Texto}:");
            Console.WriteLine();
            foreach (var item in result)
            {
                Console.WriteLine(item.Title);
            }
            Console.WriteLine();    
            Console.WriteLine("...aperte enter");
            Console.ReadKey();
            Console.WriteLine();

        }
    }

    public class SortingOption
    {
        public string? Texto { get; set; }
        public List<Parameters>? Parameters { get; set; }
    }

    public class Parameters
    {
        public string? Key { get; set; }
        public string? Value { get; set; }
    }


}