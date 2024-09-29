using lab4.Models;
using lab4.Services.Interfaces;
using Newtonsoft.Json;



namespace lab4.Services
{
    public class BookService : IBookService
    {
        private readonly string _booksFilePath = "books.json";

        public List<Book> GetBooks()
        {
            if (File.Exists(_booksFilePath))
            {
                var jsonData = File.ReadAllText(_booksFilePath);
                return JsonConvert.DeserializeObject<List<Book>>(jsonData);
            }
            return new List<Book>();
        }
    }
}
