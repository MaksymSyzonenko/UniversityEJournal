namespace University_E_Journal_PostgreSQL.CQRS.Core.Query
{
    public interface IQueryHandler<in TQuery, TResult> where TQuery : IQuery
    {
        Task<TResult> Handle(TQuery query);
    }
}

