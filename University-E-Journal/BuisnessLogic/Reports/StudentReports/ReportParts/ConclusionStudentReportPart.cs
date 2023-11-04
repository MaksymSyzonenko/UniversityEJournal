using System.Linq;
using University_E_Journal.BuisnessLogic.Base;
using University_E_Journal_PostgreSQL.Data.Entities;
using University_E_Journal_PostgreSQL.Data.Repositories.Attendances;
using University_E_Journal_PostgreSQL.Data.Repositories.Grade;
using University_E_Journal_PostgreSQL.Data.UnitOfWork;

namespace University_E_Journal.BuisnessLogic.Reports.StudentReports.ReportParts
{
    public sealed class ConclusionStudentReportPart : ReportPart<StudentEntity>
    {
        private readonly StudentEntity _entity;
        private readonly IUnitOfWork _unitOfWork;
        public ConclusionStudentReportPart(StudentEntity entity, IUnitOfWork unitOfWork)
        {
            _entity = entity;
            _unitOfWork = unitOfWork;
        }

        public override string GetStringReportPart()
        {
            var gradeRepository = (IGradeRepository)_unitOfWork.Repository<GradeEntity>();
            var attendanceRepository = (IAttendanceRepository)_unitOfWork.Repository<AttendanceEntity>();

            var grades = gradeRepository.GetGradesForStudent(_entity.Id).Result.ToList();
            var attendances = attendanceRepository.GetStudentAttendance(_entity.Id).Result.ToList();

            if (grades == null || !grades.Any() || attendances == null || !attendances.Any())
            {
                return "Conclusion: Student is at a low level of learning.";
            }

            int totalGrades = grades.Count;
            int totalScore = grades.Sum(grade => grade.Value);
            double averageScore = (double)totalScore / totalGrades;

            bool hasLowAttendance = attendances.All(a => !a.Attended) ||
                                    (attendances.Count(a => a.Attended) < attendances.Count(a => !a.Attended));
            bool belowAverageGrade = averageScore < UniversityStudyNorm.AverageStudentGrade;

            if (hasLowAttendance || belowAverageGrade)
            {
                return "Conclusion: Student is at a low level of learning.";
            }

            return "Conclusion: Student is at a normal level of learning.";
        }
    }
}
