using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TestDotnetMongodb.BusinessEntities.Entities
{
    [BsonIgnoreExtraElements]
    public class Student
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id  { get; set; }
        public string sname  { get; set; }
        
    }

}
