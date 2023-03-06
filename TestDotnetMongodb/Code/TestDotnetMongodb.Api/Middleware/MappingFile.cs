using TestDotnetMongodb.BusinessEntities.Entities;
using TestDotnetMongodb.Contracts.DTO;
using AutoMapper;

public class MappingFile : Profile
{
    public MappingFile()
    {
        // Mapping variables
		CreateMap<Student , StudentDto>(); 
    }
}
