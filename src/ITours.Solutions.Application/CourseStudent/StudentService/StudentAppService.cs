using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using System.Linq;
using Abp.Application.Services;
using ITours.Solutions.StudentCourses;
using Abp.ObjectMapping;
using AutoMapper;
using Abp.AutoMapper;
using ITours.Solutions.Helper;
using Abp.Domain.Uow;
using Abp.Modules;
using ITours.Solutions.Validator;
using Abp.UI;
using ITours.Solutions.CourseStudent.Dto.StudentDto;

namespace ITours.Solutions.CourseStudent.StudentService
{
    //[DependsOn(typeof(AbpFluentValidationModule))]
    public class StudentAppService : SolutionsAppServiceBase,IStudentAppService
    {
        private readonly IRepository<Student> _studentRepository;
        private readonly IUnitOfWorkManager _unitOfWorkManager;

        public StudentAppService(IUnitOfWorkManager unitOfWorkManager, IRepository<Student> studentRepository)
        {
            _studentRepository = studentRepository;
            _unitOfWorkManager = unitOfWorkManager;
        }

        public async Task CreateStudent(CreateStudentInput createStudentsInput)
        {
            try
            {
                var validationMaessage = string.Empty;
                var studentValidator = new StudentValidator();
                var result = studentValidator.Validate(createStudentsInput);
                if (result.IsValid)
                {
                    using (var unitOfWork = _unitOfWorkManager.Begin())
                    {
                        var student = base.ObjectMapper.Map<Student>(createStudentsInput);
                        await _studentRepository.InsertAsync(student);
                        unitOfWork.Complete();
                    }
                }
                else
                {
                    foreach (var failure in result.Errors)
                    {

                        validationMaessage += "Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage + Environment.NewLine;

                    }
                    throw new UserFriendlyException(validationMaessage);
                }
            }
            catch (Exception ex)
            {

                throw new UserFriendlyException(ex.Message); ;
            }
        }

        public async Task<StudentDto> GetByStudentId(GetByIdStudentsInput input)
        {
            try
            {
                var student = await _studentRepository.GetAsync(input.Id);
                var studentdto = MapperConfig.StudentMapper().Map<StudentDto>(student);
                return studentdto;
            }
            catch (Exception ex)
            {
                throw new UserFriendlyException(ex.Message);
            }
        }
    }
}
