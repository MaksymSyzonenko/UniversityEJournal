using University_E_Journal.BuisnessLogic.Base;
using University_E_Journal_PostgreSQL.Data.Entities;
using University_E_Journal_PostgreSQL.Data.Repositories.Grade;
using University_E_Journal_PostgreSQL.Data.UnitOfWork;

namespace University_E_Journal.BuisnessLogic.Reports.StudentReports.ReportParts
{
    public sealed class GradeStudentReportPart : ReportPart<StudentEntity>
    {
        private readonly StudentEntity _entity;
        private readonly IUnitOfWork _unitOfWork;
        public GradeStudentReportPart(StudentEntity entity, IUnitOfWork unitOfWork)
        {
            _entity = entity;
            _unitOfWork = unitOfWork;
        }

        public override string GetStringReportPart()
        {
            List<GradeEntity> grades = ((IGradeRepository)_unitOfWork.Repository<GradeEntity>()).GetGradesForStudent(_entity.Id).Result.ToList();

            if (grades == null || grades.Count == 0)
                return "Student has no grades.";

            int totalGrades = grades.Count;
            int totalScore = grades.Sum(grade => grade.Value);
            double averageScore = (double)totalScore / totalGrades;

            return $"Student has {totalGrades} total grades. Average score is {averageScore}.";
        }
    }
}
