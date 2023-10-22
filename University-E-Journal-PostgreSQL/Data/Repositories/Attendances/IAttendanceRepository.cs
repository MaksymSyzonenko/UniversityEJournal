using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University_E_Journal_PostgreSQL.Data.Entities;

namespace University_E_Journal_PostgreSQL.Data.Repositories.Attendances
{
    public interface IAttendanceRepository : IRepository
    {
        Task<IEnumerable<AttendanceEntity>> GetStudentAttendance(Guid id);
    }
}
