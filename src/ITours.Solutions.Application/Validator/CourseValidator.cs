//using FluentValidation;
using FluentValidation;
using ITours.Solutions.CourseStudent.Dto.CourseDto;
using ITours.Solutions.StudentCourses;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITours.Solutions.Validator
{
   public class CourseValidator : AbstractValidator<CreateCourseInput>
    {
        public CourseValidator()
        {
            RuleFor(x => x.Mark).InclusiveBetween(1,20);
            RuleFor(x => x.Semester).InclusiveBetween(1,16);
            RuleFor(x => x.LessonName).Length(2,100);
        }
    }
}
