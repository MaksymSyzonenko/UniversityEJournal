using University_E_Journal_PostgreSQL.Commands.Core;
using University_E_Journal_PostgreSQL.Data.DTO.Subject;

namespace University_E_Journal_PostgreSQL.Commands.Subject.Update
{
    public interface IUpdateSubjectCommand : INoResponseAsyncCommand<SubjectUpdateDto>
    {
    }
}
