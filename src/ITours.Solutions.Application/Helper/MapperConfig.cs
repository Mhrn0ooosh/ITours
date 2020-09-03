using AutoMapper;
using ITours.Solutions.CourseStudent.Dto.CourseDto;
using ITours.Solutions.CourseStudent.Dto.StudentDto;
using ITours.Solutions.StudentCourses;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITours.Solutions.Helper
{
    public static class MapperConfig
    {
        public static IMapper StudentMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Student, StudentDto>();
            });

            var mapper = config.CreateMapper();
            return mapper;
        }

        public static IMapper CourseMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Course, CourseDto>().ForMember(dest => dest.Student, opt => opt.MapFrom(src=>src.Student));
            });

            var mapper = config.CreateMapper();
            return mapper;
        }
    }

}
