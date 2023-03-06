using System.Collections.Generic;

namespace TestDotnetMongodb.Data.Interfaces
{
    public interface IGetAll<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
