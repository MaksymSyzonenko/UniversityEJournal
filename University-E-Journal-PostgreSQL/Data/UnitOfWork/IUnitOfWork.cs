using University_E_Journal_PostgreSQL.Data.Entities.Abstract;
using University_E_Journal_PostgreSQL.Data.Repositories;

namespace University_E_Journal_PostgreSQL.Data.UnitOfWork
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        Task Commit();
        IRepository Repository<TEntity>() where TEntity : BaseEntity;
    }
}

