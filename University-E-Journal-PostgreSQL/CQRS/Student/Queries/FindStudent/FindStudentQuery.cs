using University_E_Journal_PostgreSQL.CQRS.Core.Query;

namespace University_E_Journal_PostgreSQL.CQRS.Student.Queries.FindStudent
{
    public sealed record FindStudentQuery : IQuery
    {
        public Guid Id { get; }

        public FindStudentQuery(Guid id)
        {
            Id = id;
        }
    }
}