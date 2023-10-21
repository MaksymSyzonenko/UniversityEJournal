namespace University_E_Journal_PostgreSQL.Data.Repositories.Factory
{
    public interface IRepositoryFactory
    {
        IRepository Instantiate<TEntity>(UniversityEJournalDbContext context) where TEntity : class;
    }
}

