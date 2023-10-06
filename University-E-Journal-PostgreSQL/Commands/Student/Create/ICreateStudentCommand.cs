using University_E_Journal_PostgreSQL.Commands.Core;
using University_E_Journal_PostgreSQL.Data.DTO.Student;

namespace University_E_Journal_PostgreSQL.Commands.Student.Create
{
    public interface ICreateStudentCommand : INoResponseAsyncCommand<StudentDto>
    {
    }
}
