namespace University_E_Journal_PostgreSQL.Data.Repositories.Teacher
{
    public sealed class TeacherRepository : ITeacherRepository
    {
        private readonly UniversityEJournalDbContext _context;

        public TeacherRepository(UniversityEJournalDbContext context)
        {
            _context = context;
        }

        // repository methods

    }
}

