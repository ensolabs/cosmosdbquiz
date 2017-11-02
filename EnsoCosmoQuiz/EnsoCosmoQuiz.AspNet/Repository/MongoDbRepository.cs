using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace EnsoCosmoQuiz.AspNet.Repository
{
    public class MongoDbRepository
    {
        private MongoClient _mongoClient;
        private IMongoDatabase _mongoDb;
        private IMongoCollection<BsonDocument> _mongoDbCollection;

        public MongoDbRepository()
        {
            //_mongoClient = new MongoClient("[CONNECTION_STRING]");
            //_mongoDb = _mongoClient.GetDatabase("[DATABASE]");
            //_mongoDbCollection = _mongoDb.GetCollection<BsonDocument>("[COLLECTION]");
        }

        public Task<int> GetNumberOfProductionCompanies()
        {
            // Le code
            return Task.FromResult(0);
        }
    }
}