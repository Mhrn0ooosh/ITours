using Abp.Domain.Repositories;
using Abp.Domain.Uow;
//using Abp.FluentValidation;
using Abp.Modules;
using Abp.ObjectMapping;
using Abp.UI;
using ITours.Solutions.CourseStudent.Dto.CourseDto;
using ITours.Solutions.Helper;
using ITours.Solutions.StudentCourses;
using ITours.Solutions.Validator;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITours.Solutions.CourseStudent.CourseService
{
    public class CourseAppService : SolutionsAppServiceBase, ICourseAppService
    {
        private readonly IRepository<Course> _courseRepository;
        private readonly IUnitOfWorkManager _unitOfWorkManager;
        public CourseAppService(IRepository<Course> courseRepository, IUnitOfWorkManager unitOfWorkManager)
        {
            _courseRepository = courseRepository;
            _unitOfWorkManager = unitOfWorkManager;
        }
        public async Task<CourseDto> GetByCourseIdAsync(GetByIdCourseInput getByIdCourseInput)
        {
            try
            {
                var entity = _courseRepository.GetAllIncluding(p => p.Student).FirstOrDefault(p => p.Id == getByIdCourseInput.Id);
                var courseDto = MapperConfig.CourseMapper().Map<CourseDto>(entity);
                return courseDto;
            }
            catch (Exception ex)
            {
                throw new UserFriendlyException(ex.Message);
            }

        }

        public async Task CreateCourse(CreateCourseInput createCourseInput)
        {
            try
            {
                var validationMaessage = string.Empty;
                var courseValidator = new CourseValidator();
                var result = courseValidator.Validate(createCourseInput);
                if (result.IsValid)
                {
                    using (var unitOfWork = _unitOfWorkManager.Begin())
                    {
                        var course = base.ObjectMapper.Map<Course>(createCourseInput);
                        await _courseRepository.InsertAsync(course);
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
                throw new UserFriendlyException(ex.Message);
            }
        }
    }
}
