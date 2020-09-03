using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using FluentValidation;
using ITours.Solutions.CourseStudent.Dto.StudentDto;
using ITours.Solutions.StudentCourses;

namespace ITours.Solutions.Validator
{
    public class StudentValidator : AbstractValidator<CreateStudentInput>
    {
        public StudentValidator()
        {
            RuleFor(x => x.EnteranceYear).InclusiveBetween(1300,1500);
            RuleFor(x => x.Gender).Length(2,15);
            RuleFor(x => x.Field).Length(2, 100);
        }
    }
}
