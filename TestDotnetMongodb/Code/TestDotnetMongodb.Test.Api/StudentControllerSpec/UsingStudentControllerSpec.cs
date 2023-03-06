using NSubstitute;
using TestDotnetMongodb.Test.Framework;
using TestDotnetMongodb.Api.Controllers;
using TestDotnetMongodb.BusinessServices.Interfaces;
using AutoMapper;
using TestDotnetMongodb.BusinessEntities.Entities;
using TestDotnetMongodb.Contracts.DTO;


namespace TestDotnetMongodb.Test.Api.StudentControllerSpec
{
    public abstract class UsingStudentControllerSpec : SpecFor<StudentController>
    {
        protected IStudentService _studentService;
        protected IMapper _mapper;

        public override void Context()
        {
            _studentService = Substitute.For<IStudentService>();
            _mapper = Substitute.For<IMapper>();
            subject = new StudentController(_studentService,_mapper);

        }

    }
}
