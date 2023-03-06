using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes; 
using System.Runtime.Serialization; 
namespace TestDotnetMongodb.Contracts.DTO {
   public class StudentDto { 
     public string Id { get; set; }
        public string sname { get; set; } 
} 
}
