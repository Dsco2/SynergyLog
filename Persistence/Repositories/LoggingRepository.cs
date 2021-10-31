using System.Collections.Generic;
using System.IO;
using Business.Interfaces;
using Business.Models;
using MongoDB.Driver;

namespace Persistence.Repositories
{
    public class LoggingRepository : ILoggingRepository
    {
        private readonly IMongoCollection<Synergy> _books;

        public LoggingRepository(IBookstoreDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _books = database.GetCollection<Synergy>(settings.BooksCollectionName);
        }

        public List<Synergy> Get()
        {
            return _books.Find(book => true).ToList();
        }

        public void CreateElement(Synergy temp)
        {

                _books.InsertOne(temp);

            
        }

        public Synergy Get(string id) =>
            _books.Find<Synergy>(book => book.Id == id).FirstOrDefault();


        public Synergy Create(Synergy book)
        {
            _books.InsertOne(book);
            return book;
        }

        public void Update(string id,Synergy bookIn) =>
            _books.ReplaceOne(book => book.Id == id,bookIn);

        public void Remove(Synergy bookIn) =>
            _books.DeleteOne(book => book.Id == bookIn.Id);

        public void Remove(string id) =>
            _books.DeleteOne(book => book.Id == id);


    }
}
