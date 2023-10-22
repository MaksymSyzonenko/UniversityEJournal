using University_E_Journal_PostgreSQL.CQRS.Core.Command;

namespace University_E_Journal_PostgreSQL.CQRS.Student.Commands.Create
{
    public sealed record CreateStudentCommand : ICommand
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int YearStudyStart { get; }
        public Guid GroupId { get; }

        public CreateStudentCommand(string firstName, string lastName, int yearStudyStart, Guid groupId)
        {
            FirstName = firstName;
            LastName = lastName;
            YearStudyStart = yearStudyStart;
            GroupId = groupId;
        }

    }
}