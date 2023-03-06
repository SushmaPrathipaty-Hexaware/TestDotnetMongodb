using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NSubstitute;
using Shouldly;
using Microsoft.AspNetCore.Mvc;
using TestDotnetMongodb.BusinessEntities.Entities;
using TestDotnetMongodb.Contracts.DTO;
using TestDotnetMongodb.BusinessServices.Services;

namespace TestDotnetMongodb.Test.Api.StudentControllerSpec
{
    public class When_saving_student : UsingStudentControllerSpec
    {
        private ActionResult<StudentDto> _result;

        private Student _student;
        private StudentDto _studentDto;

        public override void Context()
        {
            base.Context();

            _student = new Student
            {
                sname = "sname"
            };

            _studentDto = new StudentDto{
                    sname = "sname"
            };

            _studentService.Save(_student).Returns(_student);
            _mapper.Map<StudentDto>(_student).Returns(_studentDto);
        }
        public override void Because()
        {
            _result = subject.Save(_student);
        }

        [Test]
        public void Request_is_routed_through_service()
        {
            _studentService.Received(1).Save(_student);

        }

        [Test]
        public void Appropriate_result_is_returned()
        {
            _result.Result.ShouldBeOfType<OkObjectResult>();

            var resultListObject = (_result.Result as OkObjectResult).Value;

            resultListObject.ShouldBeOfType<StudentDto>();

            var resultList = (StudentDto)resultListObject;

            resultList.ShouldBe(_studentDto);
        }
    }
}
