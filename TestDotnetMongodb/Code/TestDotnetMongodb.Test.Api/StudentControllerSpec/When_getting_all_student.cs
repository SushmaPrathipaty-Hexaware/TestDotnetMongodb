using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NSubstitute;
using Shouldly;
using Microsoft.AspNetCore.Mvc;
using TestDotnetMongodb.BusinessEntities.Entities;
using TestDotnetMongodb.Contracts.DTO;

namespace TestDotnetMongodb.Test.Api.StudentControllerSpec
{
    public class When_getting_all_student : UsingStudentControllerSpec
    {
        private ActionResult<IEnumerable<StudentDto>> _result;

        private IEnumerable<Student> _all_student;
        private Student _student;

        private IEnumerable<StudentDto>  _all_studentDto;
        private StudentDto _studentDto;
    

        public override void Context()
        {
            base.Context();

            _student = new Student{
                sname = "sname"
            };

            _studentDto = new StudentDto{
                    sname = "sname"
                };

            _all_student = new List<Student> { _student};
            _studentService.GetAll().Returns(_all_student);
            _all_studentDto  = new List<StudentDto> {_studentDto};
            _mapper.Map<IEnumerable<StudentDto>>(_all_student).Returns( _all_studentDto);
        }
        public override void Because()
        {
            _result = subject.Get();
        }

        [Test]
        public void Request_is_routed_through_service()
        {
            _studentService.Received(1).GetAll();

        }

        [Test]
        public void Appropriate_result_is_returned()
        {
            _result.Result.ShouldBeOfType<OkObjectResult>();

            var resultListObject = (_result.Result as OkObjectResult).Value;

            resultListObject.ShouldBeOfType<List<StudentDto>>();

            List<StudentDto> resultList = resultListObject as List<StudentDto>;

            resultList.Count.ShouldBe(1);

            resultList.ShouldBe(_all_studentDto);
        }
    }
}
