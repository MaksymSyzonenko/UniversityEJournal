using University_E_Journal_PostgreSQL.CQRS.Core.Query;

namespace University_E_Journal_PostgreSQL.CQRS.Grade.Queries.GetBestResults
{
    public sealed class GetBestResultsQuery : IQuery
    {
        public Guid SubjectId { get; }
        public Guid GroupId { get; }
        public GetBestResultsQuery(Guid subjectId, Guid groupId)
        {
            SubjectId = subjectId;
            GroupId = groupId;
        }
    }
}
