using University_E_Journal.BuisnessLogic.Base;
using University_E_Journal_PostgreSQL.Data.Entities;

namespace University_E_Journal.BuisnessLogic.Reports.StudentReports.ReportParts
{
    public sealed class TitleStudentReportPart : ReportPart<StudentEntity>
    {
        private readonly StudentEntity _entity;
        public TitleStudentReportPart(StudentEntity entity)
        {
            _entity = entity;
        }
        public override string GetStringReportPart() => $"Student report about: {_entity.FirstName} {_entity.LastName}.";
    }
}
