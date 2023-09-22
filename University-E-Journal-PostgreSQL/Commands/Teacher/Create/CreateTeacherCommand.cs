using University_E_Journal_PostgreSQL.Data.DTO;
using University_E_Journal_PostgreSQL.Data.Entities;
using University_E_Journal_PostgreSQL.Data;

namespace University_E_Journal_PostgreSQL.Commands.Teacher.Create
{
    public sealed class CreateTeacherCommand : ICreateTeacherCommand
    {
        private readonly UniversityEJournalDbContext _context;
        public CreateTeacherCommand(UniversityEJournalDbContext context)
        {
            _context = context;
        }
        public async Task ExecuteAsync(TeacherDto dto)
        {
            TeacherEntity teacher = new()
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Department = dto.Department
            };

            _context.Teachers.Add(teacher);
            await _context.SaveChangesAsync();
        }
    }
}
