using University_E_Journal_PostgreSQL.CQRS.Core.Command;

namespace University_E_Journal_PostgreSQL.CQRS.Grade.Commands.Add
{
    public sealed class AddGradeCommand : ICommand
    {
        public int Value { get; }
        public DateOnly Date { get; }
        public Guid StudentId { get; }
        public Guid SubjectId { get; }
        public Guid TeacherId { get; }
        public AddGradeCommand(int value, DateOnly date, Guid studentId, Guid subjectId, Guid teacherId)
        {
            Value = value;
            Date = date;
            StudentId = studentId;
            SubjectId = subjectId;
            TeacherId = teacherId;
        }
    }
}
