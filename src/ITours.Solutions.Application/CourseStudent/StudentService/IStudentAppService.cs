using Abp.Application.Services;
using ITours.Solutions.CourseStudent.Dto.StudentDto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ITours.Solutions.CourseStudent.StudentService
{
   public interface IStudentAppService : IApplicationService
    {
        [HttpGet]
        Task<StudentDto> GetByStudentId(GetByIdStudentsInput getByIdStudentsInput);

        [HttpPost]
        Task CreateStudent(CreateStudentInput createStudentsInput);
    }
}
