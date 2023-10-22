using University_E_Journal.BuisnessLogic.Base;
using University_E_Journal_PostgreSQL.Data.Entities;
using University_E_Journal_PostgreSQL.Data.Repositories.Attendances;
using University_E_Journal_PostgreSQL.Data.Repositories.Student;
using University_E_Journal_PostgreSQL.Data.UnitOfWork;

namespace University_E_Journal.BuisnessLogic.Reports.StudentReports.ReportParts
{
    public sealed class TruancyStudentReportPart : ReportPart<StudentEntity>
    {
        private readonly StudentEntity _entity;
        private readonly IUnitOfWork _unitOfWork;
        public TruancyStudentReportPart(StudentEntity entity, IUnitOfWork unitOfWork)
        {
            _entity = entity;
            _unitOfWork = unitOfWork;
        }
        public override string GetStringReportPart()
        {
            List<AttendanceEntity> attendances = ((IAttendanceRepository)_unitOfWork
                .Repository<AttendanceEntity>())
                .GetStudentAttendance(_entity.Id).Result.ToList();

            if (attendances == null || attendances.Count == 0 || attendances.All(a => !a.Attended))
                return "Student has no attendances.";

            int result = attendances.Count(attendance => attendance.Attended);
            return $"Student has {result} absences.";
        }
    }
}
