using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ITours.Solutions.StudentCourses
{
    public class Course : Entity
    {
        public int Semester { get; set; }
        public int Mark { get; set; }
        public string LessonName { get; set; }

        //FK
        public int StudentId { get; set; }
        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }
    }
}
