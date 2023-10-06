using University_E_Journal_PostgreSQL.CQRS.Core.Command;

namespace University_E_Journal_PostgreSQL.CQRS.Student.Commands.Create
{
    public interface ICreateStudentCommandHandler : ICommandHandler<CreateStudentCommand>
    {

    }
}