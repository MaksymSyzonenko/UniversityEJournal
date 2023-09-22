using University_E_Journal_PostgreSQL.Data;
using University_E_Journal_PostgreSQL.Data.DTO;

namespace University_E_Journal_PostgreSQL.Commands.Subject.Update
{
    public sealed class UpdateSubjectCommand : IUpdateSubjectCommand
    {
        private readonly UniversityEJournalDbContext _context;
        public UpdateSubjectCommand(UniversityEJournalDbContext context)
        {
            _context = context;
        }
        public async Task ExecuteAsync(SubjectUpdateDto data)
        {
            var subjectToUpdate = await _context.Subjects.FindAsync(data.Id);
            if (subjectToUpdate != null)
            {
                _context.Entry(subjectToUpdate).CurrentValues.SetValues(data.dto);
                await _context.SaveChangesAsync();
            }
        }
    }
}
