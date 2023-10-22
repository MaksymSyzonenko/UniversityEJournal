using Microsoft.AspNetCore.Mvc;
using University_E_Journal.BuisnessLogic.Reports.StudentReports;
using University_E_Journal_PostgreSQL.Commands.Group.Create;
using University_E_Journal_PostgreSQL.Data.DTO.Group;
using University_E_Journal_PostgreSQL.Data.Entities;
using University_E_Journal_PostgreSQL.Data.Repositories.Student;
using University_E_Journal_PostgreSQL.Data.UnitOfWork;

namespace University_E_Journal.Controllers.Report.Student
{
    [ApiController]
    [Route("studentReports")]
    [ApiExplorerSettings(GroupName = "studentReports")]
    public class StudentReportController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public StudentReportController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpPost]
        [Route("getReport")]
        public async Task<string> GetReport([FromBody] string id)
        {
            StudentEntity? student = await ((IStudentRepository)_unitOfWork.Repository<StudentEntity>()).FindSingle(Guid.Parse(id));
            if (student == null)
                return "Failed id.";
            StudentReport report = new(student!, _unitOfWork);
            return report.GetStringReport();
        }
    }
}
