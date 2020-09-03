using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ITours.Solutions.StudentCourses;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITours.Solutions.CourseStudent.Dto.StudentDto
{
    [AutoMapTo(typeof(Student))]
    public class StudentDto : EntityDto
    {
        public string Name { get; set; }
        public string Field { get; set; }
        public int EnteranceYear { get; set; }
        public string Gender { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
