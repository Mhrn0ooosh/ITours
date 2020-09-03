using Abp.AutoMapper;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITours.Solutions.StudentCourses
{
    public class Student: Entity, IHasCreationTime
    {
        public Student()
        {
            CreationTime = Clock.Now;
        }
        public string Name { get; set; }
        public string Field { get; set; }
        public int EnteranceYear { get; set; }
        public string Gender { get; set; }
        public DateTime CreationTime { get; set; }
    }
}




