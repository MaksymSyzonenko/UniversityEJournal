using University_E_Journal_PostgreSQL.CQRS.Core.Command;

namespace University_E_Journal_PostgreSQL.CQRS.Grade.Commands.Add
{
    public sealed class AddGradeCommand : ICommand
    {
        public int Value { get; set; }
        public DateOnly Date { get; set; }
        public Guid StudentId { get; set; }
        public Guid SubjectId { get; set; }
        public Guid TeacherId { get; set; }
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
