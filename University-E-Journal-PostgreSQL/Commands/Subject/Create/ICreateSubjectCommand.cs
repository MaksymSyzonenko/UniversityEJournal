using University_E_Journal_PostgreSQL.Commands.Core;
using University_E_Journal_PostgreSQL.Data.DTO.Subject;

namespace University_E_Journal_PostgreSQL.Commands.Subject.Create
{
    public interface ICreateSubjectCommand : INoResponseAsyncCommand<SubjectDto>
    {
    }
}
