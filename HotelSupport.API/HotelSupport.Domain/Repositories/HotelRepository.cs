using ChatBot.HotelSupport.Domain.Entities;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace ChatBot.HotelSupport.Domain.Repositories;

public class HotelRepository
{
    public static IMongoDatabase database { get; set; }
    
    public HotelRepository()
    {
        var connectionString = "mongodb://localhost:27017"; //change with remote db
        var client = new MongoClient(connectionString);
        var databaseName = "your_database_name";
        database = client.GetDatabase(databaseName);
    }

    public static IQueryable<Hotel> Table => database.GetCollection<Hotel>("Hotel").AsQueryable();
}