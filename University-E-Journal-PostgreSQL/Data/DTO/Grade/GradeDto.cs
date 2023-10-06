
namespace University_E_Journal_PostgreSQL.Data.DTO.Grade
{
    public sealed class GradeDto
    {
        public int Value { get; set; }
        public DateOnly Date { get; set; }
        public Guid StudentId { get; set; }
        public Guid SubjectId { get; set; }
        public Guid TeacherId { get; set; }
    }
}
