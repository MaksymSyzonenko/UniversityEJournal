using University_E_Journal_PostgreSQL.Commands.Core;

namespace University_E_Journal_PostgreSQL.Commands.Grade.Cancel
{
    public interface ICancelGradeCommand : INoResponseAsyncCommand<Guid>
    {
    }
}
