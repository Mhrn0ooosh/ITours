using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITours.Solutions.Average
{
    public interface IAverageAppService : IApplicationService
    {
        double GetTotalStudentAverage(int studentId);
        double GetStudentAverageBySemester(int studentId, int semester);
        double GetUniversityAverage();
    }
}
