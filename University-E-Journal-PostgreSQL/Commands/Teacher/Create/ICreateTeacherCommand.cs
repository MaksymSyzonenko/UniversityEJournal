using University_E_Journal_PostgreSQL.Commands.Core;
using University_E_Journal_PostgreSQL.Data.DTO.Teacher;

namespace University_E_Journal_PostgreSQL.Commands.Teacher.Create
{
    public interface ICreateTeacherCommand : INoResponseAsyncCommand<TeacherDto>
    {
    }
}
