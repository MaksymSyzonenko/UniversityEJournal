
using Microsoft.EntityFrameworkCore;
using University_E_Journal_PostgreSQL.Data.Entities;

namespace University_E_Journal_PostgreSQL.Data.Repositories.Student
{
    public sealed class StudentRepository : IStudentRepository
    {
        private readonly UniversityEJournalDbContext _context;
    
        public StudentRepository(UniversityEJournalDbContext context)
        {
            _context = context;
        }

        public async Task Create(StudentEntity entity)
        {
            await _context.Students.AddAsync(entity);
        }

        public async Task<StudentEntity?> FindSingle(Guid id)
        {
            return await _context.Students.SingleOrDefaultAsync(p => p.Id == id);
        }

        
    }
}