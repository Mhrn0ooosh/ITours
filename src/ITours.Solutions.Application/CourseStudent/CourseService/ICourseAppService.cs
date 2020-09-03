using Abp.Application.Services;
using ITours.Solutions.CourseStudent.Dto.CourseDto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ITours.Solutions.CourseStudent.CourseService
{
    public interface ICourseAppService : IApplicationService
    {
        [HttpGet]
        Task<CourseDto> GetByCourseIdAsync(GetByIdCourseInput getByIdCourseInput);

        [HttpPost]
        Task CreateCourse(CreateCourseInput createCourseInput);
    }
}
