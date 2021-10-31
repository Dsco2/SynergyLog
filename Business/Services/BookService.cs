using System.Collections.Generic;
using Business.Interfaces;
using Business.Models;
using MongoDB.Driver;

namespace Business.Services
{
    public class BookService
    {
        private readonly IMongoCollection<Book> _books;

        public BookService(IBookstoreDatabaseSettings settings)
        {





            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);


            //var client = new MongoClient("mongodb+srv://Dsco:Admin@cluster0.mongodb.net/Process?w=majority");
            //var database = client.GetDatabase("Process");

            _books = database.GetCollection<Book>(settings.BooksCollectionName);
        }

        //public List<Book> Get() =>
        //    _books.Find(book => true).ToList();


        public List<Book> Get()
        {
            var test = _books.Find(book => true).ToList();

            return new List<Book>();
        }

        public Book Get(string id) =>
            _books.Find<Book>(book => book.Id == id).FirstOrDefault();


        public Book Create(Book book)
        {
            book = new Book {BookName = "test", Author = "daniel"};


            _books.InsertOne(book);
            return book;
        }

        public void Update(string id,Book bookIn) =>
            _books.ReplaceOne(book => book.Id == id,bookIn);

        public void Remove(Book bookIn) =>
            _books.DeleteOne(book => book.Id == bookIn.Id);

        public void Remove(string id) =>
            _books.DeleteOne(book => book.Id == id);
    }
}
