using MongoDB.Driver;

namespace TestDotnetMongodb.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
