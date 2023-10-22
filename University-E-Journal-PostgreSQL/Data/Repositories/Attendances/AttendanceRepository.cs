using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University_E_Journal_PostgreSQL.Data.Entities;

namespace University_E_Journal_PostgreSQL.Data.Repositories.Attendances
{
    public sealed class AttendanceRepository : IAttendanceRepository
    {
        private readonly UniversityEJournalDbContext _context;
        public AttendanceRepository(UniversityEJournalDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AttendanceEntity>> GetStudentAttendance(Guid id)
            => await _context.Attendances.Where(a => a.StudentId == id).ToListAsync();
    }
}
