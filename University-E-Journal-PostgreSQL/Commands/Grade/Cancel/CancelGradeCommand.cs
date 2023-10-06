using University_E_Journal_PostgreSQL.Data;

namespace University_E_Journal_PostgreSQL.Commands.Grade.Cancel
{
    public sealed class CancelGradeCommand : ICancelGradeCommand
    {
        private readonly UniversityEJournalDbContext _context;
        public CancelGradeCommand(UniversityEJournalDbContext context)
        {
            _context = context;
        }
        public async Task ExecuteAsync(Guid Id)
        {
            var grade = await _context.Grades.FindAsync(Id);
            if (grade != null)
            {
                grade.Value = 0;
                await _context.SaveChangesAsync();
            }
        }
    }
}
