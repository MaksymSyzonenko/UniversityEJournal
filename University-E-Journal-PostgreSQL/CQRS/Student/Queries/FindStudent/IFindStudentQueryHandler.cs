using University_E_Journal_PostgreSQL.CQRS.Core.Query;
using University_E_Journal_PostgreSQL.Data.Entities;

namespace University_E_Journal_PostgreSQL.CQRS.Student.Queries.FindStudent
{
    public interface IFindStudentQueryHandler : IQueryHandler<FindStudentQuery, StudentEntity?>
    {

    }
}