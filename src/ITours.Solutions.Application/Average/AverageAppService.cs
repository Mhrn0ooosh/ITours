using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Linq;
using ITours.Solutions.StudentCourses;

namespace ITours.Solutions.Average
{
    public class AverageAppService : IAverageAppService
    {
        private readonly IRepository<Course> _courseRepository;
        public AverageAppService(IRepository<Course> courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public double GetStudentAverageBySemester(int studentId, int semester)
        {
            return _courseRepository.GetAll().Where(x => x.StudentId == studentId && x.Semester == semester).Select(x => x.Mark).Average();
        }
        public double GetTotalStudentAverage(int studentId)
        {
            return _courseRepository.GetAll().Where(x => x.StudentId == studentId).Select(x => x.Mark).Average();
        }
        public double GetUniversityAverage()
        {
            return _courseRepository.GetAll().Select(x => x.Mark).Average();
        }
    }
}
