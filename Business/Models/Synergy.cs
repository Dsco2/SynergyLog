
using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Business.Models
{
    public class Synergy
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public DateTime Date { get; set; }

        public string Text { get; set; }
    }
}
