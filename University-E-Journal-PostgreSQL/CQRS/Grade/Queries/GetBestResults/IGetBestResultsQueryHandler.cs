using University_E_Journal_PostgreSQL.CQRS.Core.Query;

namespace University_E_Journal_PostgreSQL.CQRS.Grade.Queries.GetBestResults
{
    public interface IGetBestResultsQueryHandler : IQueryHandler<GetBestResultsQuery, string>
    {

    }
}
