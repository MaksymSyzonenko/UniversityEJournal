using University_E_Journal_PostgreSQL.CQRS.Core.Query;

namespace University_E_Journal_PostgreSQL.MediatorImpl
{
    public interface IQueryMediator
    {
        public Task<TResult> Send<TQuery, TResult>(TQuery query) where TQuery : IQuery;
    }
}

