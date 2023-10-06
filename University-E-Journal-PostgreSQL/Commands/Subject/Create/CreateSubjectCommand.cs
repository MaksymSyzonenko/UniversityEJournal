using University_E_Journal_PostgreSQL.Data.DTO;
using University_E_Journal_PostgreSQL.Data.Entities;
using University_E_Journal_PostgreSQL.Data;

namespace University_E_Journal_PostgreSQL.Commands.Subject.Create
{
    public sealed class CreateSubjectCommand : IUpdateSubjectCommand
    {
        private readonly UniversityEJournalDbContext _context;
        public CreateSubjectCommand(UniversityEJournalDbContext context)
        {
            _context = context;
        }
        public async Task ExecuteAsync(SubjectDto dto)
        {
            SubjectEntity subject = new()
            {
                Name = dto.Name,
                TeacherID = dto.TeacherID,
            };

            _context.Subjects.Add(subject);
            await _context.SaveChangesAsync();
        }
    }
}
