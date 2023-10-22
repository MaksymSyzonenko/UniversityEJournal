using System.Reflection;
using University_E_Journal.BuisnessLogic.Base;
using University_E_Journal.BuisnessLogic.Reports.StudentReports.ReportParts;
using University_E_Journal_PostgreSQL.Data.Entities;
using University_E_Journal_PostgreSQL.Data.UnitOfWork;

namespace University_E_Journal.BuisnessLogic.Reports.StudentReports
{
    public sealed class StudentReport : Report<StudentEntity>
    {
        private readonly IUnitOfWork _unitOfWork;
        public StudentReport(StudentEntity entity, IUnitOfWork unitOfWork) : base(entity) 
        {
            _unitOfWork = unitOfWork;
        }
        
        protected override void CreateReport()
        {
            Parts.Add(new TitleStudentReportPart(_entity));
            Parts.Add(new GradeStudentReportPart(_entity, _unitOfWork));
            Parts.Add(new TruancyStudentReportPart(_entity, _unitOfWork));
            Parts.Add(new ConclusionStudentReportPart(_entity, _unitOfWork));
        }
    }
}
