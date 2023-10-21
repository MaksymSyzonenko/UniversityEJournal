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
            List<GradeEntity> grades = ((IGradeRepository)_unitOfWork.Repository<GradeEntity>()).GetGradesForStudent(_entity.Id).Result.ToList();

            List<AttendanceEntity> attendances = ((IAttendanceRepository)_unitOfWork
                .Repository<AttendanceEntity>())
                .GetStudentAttendance(_entity.Id).Result.ToList();

            string result = string.Empty;

            int totalGrades = grades.Count;
            int totalScore = grades.Sum(grade => grade.Value);
            double averageScore = (double)totalScore / totalGrades;

            if (grades == null || grades.Count == 0 || attendances == null
                || attendances.Count == 0 || attendances.All(a => !a.Attended)
                || (attendances.Count(a => a.Attended) < attendances.Count(a => !a.Attended))
                || averageScore < UniversityStudyNorm.AverageStudentGrade)
            {
                result = "Conclusion: Student is at a low level of learning.";
            }
            else
                result = "Conclusion: Student is at a normal level of learning.";

            return result;
        }
    }
}
