using Abp.AutoMapper;
using ITours.Solutions.StudentCourses;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITours.Solutions.CourseStudent.Dto.CourseDto
{
    [AutoMapTo(typeof(Course))]
    public class CreateCourseInput
    {
        public int Semester { get; set; }
        public int Mark { get; set; }
        public string LessonName { get; set; }
        public int StudentId { get; set; }
    }
}
