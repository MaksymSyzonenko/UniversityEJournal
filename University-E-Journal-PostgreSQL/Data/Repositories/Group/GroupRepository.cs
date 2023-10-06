
namespace University_E_Journal_PostgreSQL.Data.Repositories.Group
{
    public sealed class GroupRepository : IGroupRepository
    {
        private readonly UniversityEJournalDbContext _context;

        public GroupRepository(UniversityEJournalDbContext context)
        {
            _context = context;
        }
    }
}

