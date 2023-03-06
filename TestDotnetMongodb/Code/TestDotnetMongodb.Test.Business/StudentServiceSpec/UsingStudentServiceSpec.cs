using NSubstitute;
using TestDotnetMongodb.Test.Framework;
using TestDotnetMongodb.BusinessServices.Services;
using TestDotnetMongodb.Data.Interfaces;

namespace TestDotnetMongodb.Test.Business.StudentServiceSpec
{
    public abstract class UsingStudentServiceSpec : SpecFor<StudentService>
    {
        protected IStudentRepository _studentRepository;

        public override void Context()
        {
            _studentRepository = Substitute.For<IStudentRepository>();
            subject = new StudentService(_studentRepository);

        }

    }
}
