
namespace University_E_Journal_PostgreSQL.Data.Repositories.Subject
{
    public sealed class SubjectRepository : ISubjectRepository
    {
        private readonly UniversityEJournalDbContext _context;
        public SubjectRepository(UniversityEJournalDbContext context) 
        {
            _context = context;
        }
    }
}
