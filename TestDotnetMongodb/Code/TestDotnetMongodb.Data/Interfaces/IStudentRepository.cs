using TestDotnetMongodb.BusinessEntities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDotnetMongodb.Data.Interfaces
{
    public interface IStudentRepository : IGetAll<Student>,IGet<Student,string>, ISave<Student>, IUpdate<Student, string>, IDelete<string>
    {
    }
}
